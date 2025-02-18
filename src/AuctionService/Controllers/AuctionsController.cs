using AuctionService.Models;
using AuctionService.Models.Entities.Auctions;
using AuctionService.Models.Records.Auctions;
using Contracts;
using Mapster;
using MapsterMapper;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Controllers
{
    [ApiController]
    [Route("api/auctions")]
    public class AuctionsController : ControllerBase
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;

        public AuctionsController(
            AuctionDbContext context, 
            IMapper mapper,
            IPublishEndpoint publishEndpoint)
        {
            _context = context;
            _mapper = mapper;
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<ActionResult<AuctionRecord>> CreateAsync(CreateAuctionRecord createAuctionRecord)
        {
            var auction = _mapper.Map<Auction>(createAuctionRecord);
            auction.Seller = "test";

            _context.Auctions.Add(auction);

            var newAuction = _mapper.Map<AuctionRecord>(auction);

            await _publishEndpoint.Publish(_mapper.Map<AuctionCreated>(newAuction));

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return BadRequest("Could not save changes to the DB.");

            return CreatedAtAction(nameof(RetrieveById), new { id = auction.Id }, newAuction);
        }

        [HttpGet]
        public async Task<ActionResult<List<AuctionRecord>>> Retrieve(string date)
        {
            var query = _context.Auctions
                .OrderBy(a => a.Item.Make)
                .AsQueryable();

            if (!string.IsNullOrEmpty(date))
            {
                query = query.Where(a => a.UpdatedAt
                    .CompareTo(DateTime.Parse(date).ToUniversalTime()) > 0);
            }

            return await query.ProjectToType<AuctionRecord>(_mapper.Config).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuctionRecord>> RetrieveById(Guid id)
        {
            var auction = await _context.Auctions
                .Include(a => a.Item)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (auction is null)
                return NotFound();

            return _mapper.Map<AuctionRecord>(auction);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AuctionRecord>> UpdateAsync(Guid id, UpdateAuctionRecord updateAuctionRecord)
        {
            var auction = await _context.Auctions
                .Include(a => a.Item)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (auction is null)  return NotFound();
            

            auction.Item.Make = updateAuctionRecord.Make ?? auction.Item.Make;
            auction.Item.Model = updateAuctionRecord.Model ?? auction.Item.Model;
            auction.Item.Year = updateAuctionRecord.Year != 0 ? updateAuctionRecord.Year : auction.Item.Year;
            auction.Item.Color = updateAuctionRecord.Color ?? auction.Item.Color;
            auction.Item.Mileage = updateAuctionRecord.Mileage != 0 ? updateAuctionRecord.Mileage : auction.Item.Mileage;


            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest("Could not save changes to the DB.");

            return _mapper.Map<AuctionRecord>(auction);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<AuctionRecord>> UpdateStatusAsync(Guid id)
        {
            var auction = await _context.Auctions
                .Include(a => a.Item)
                .FirstOrDefaultAsync(a => a.Id == id);
            if (auction is null) return NotFound();

            auction.IsDeleted = true;
            var result = await _context.SaveChangesAsync() > 0;
            if (!result) return BadRequest("Could not save changes to the DB.");
            return _mapper.Map<AuctionRecord>(auction);
        }


    }
}
