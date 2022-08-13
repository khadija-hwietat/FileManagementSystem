using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Repository.Data;
using Services.Interfaces;
using Services.Models;

namespace FileManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IService<FileManagmentSystemContext , FileModel, FileDTO> _service;
        

        public FileController( IService<FileManagmentSystemContext , FileModel , FileDTO> service)
        {
           
            _service = service;
        }

        // GET: api/File
        [HttpGet]
        public IEnumerable<FileDTO> GetFileModel()
        {
          return  _service.GetAll();
        }

        // GET: api/File/5
        [HttpGet("{id}")]
        public FileDTO GetFileModel(long id)
        {
            return _service.GetById(id);

        }

        //// PUT: api/File/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFileModel(long id, FileModel fileModel)
        //{
        //    return _service.(id);
        //}

        // POST: api/File
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostFileModel(FileModel fileModel)
        {
            _service.Add(fileModel);
        }

        //// DELETE: api/File/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFileModel(long id)
        //{
        //    if (_context.FileModel == null)
        //    {
        //        return NotFound();
        //    }
        //    var fileModel = await _context.FileModel.FindAsync(id);
        //    if (fileModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.FileModel.Remove(fileModel);
        //    if (System.IO.Directory.Exists(fileModel.Path))
        //    {
        //        System.IO.Directory.Delete(fileModel.Path);
        //    }
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FileModelExists(long id)
        //{
        //    return (_context.FileModel?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
