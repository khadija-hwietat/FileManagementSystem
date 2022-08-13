using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Domain.Models;

namespace FileManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private readonly IMapper _mapper;

        public FolderController( IMapper mapper)
        {
            _mapper = mapper;


        }

        // GET: api/FolderModels
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<FolderDTO>>> GetFolderModel()
        //{
        //  if (_context.FolderModel == null)
        //  {
        //      return NotFound();
        //  }
        //  var models = await _context.FolderModel.ToListAsync();
        //    var data = _mapper.Map<IEnumerable<FolderDTO>>(models);
        //    return new ActionResult<IEnumerable<FolderDTO> >(data);
        //}

        //// GET: api/FolderModels/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<FolderDTO>> GetFolderModel(long id)
        //{
        //  if (_context.FolderModel == null)
        //  {
        //      return NotFound();
        //  }
        //    var folderModel = await _context.FolderModel.FindAsync(id);

        //    if (folderModel == null)
        //    {
        //        return NotFound();
        //    }
        //    var data = _mapper.Map<FolderDTO>(folderModel);
        //    return new ActionResult<FolderDTO>(data);
        //}

        //// PUT: api/FolderModels/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFolderModel(long id, FolderDTO folderModel)
        //{
        //    if (id != folderModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(folderModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FolderModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/FolderModels
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<FolderDTO>> PostFolderModel(FolderModel folderModel)
        //{
        //  if (_context.FolderModel == null)
        //  {
        //      return Problem("Entity set 'FileManagmentSystemContext.FolderModel'  is null.");
        //  }
        //    _context.FolderModel.Add(folderModel);
        //    await _context.SaveChangesAsync();
        //    string path1 = @"D:\MyCode\FileManagmentSystem\FileManagmentSystem\Directory";
        //    string path2 = Path.Combine(path1, folderModel.Name + folderModel.Id);

        //    if (!Directory.Exists(path2))
        //    {
        //        Directory.CreateDirectory(path2);

        //    }
        //    folderModel.Path = path2;
        //    _context.FolderModel.Update(folderModel);
        //    await _context.SaveChangesAsync();
            

        //    return CreatedAtAction("GetFolderModel", new { id = folderModel.Id }, folderModel);
        //}

        //// DELETE: api/FolderModels/5
        //[HttpDelete("{id}")]
        //// send header or body to delete with subfolder 
        //public async Task<IActionResult> DeleteFolderModel(long id)
        //{
        //    if (_context.FolderModel == null)
        //    {
        //        return NotFound();
        //    }
        //    var folderModel = await _context.FolderModel.FindAsync(id);
        //    if (folderModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FolderModel.Remove(folderModel);
        //    //Delete With sub folder ?
        //    if (System.IO.Directory.Exists(folderModel.Path))
        //    {
        //        System.IO.Directory.Delete(folderModel.Path);
        //    }
     
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FolderModelExists(long id)
        //{
        //    return (_context.FolderModel?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
