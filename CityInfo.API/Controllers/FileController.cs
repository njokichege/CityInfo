using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FileController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider
                ?? throw new System.ArgumentNullException(nameof(fileExtensionContentTypeProvider));
        }
        [HttpGet("{fileid}")]
        public ActionResult GetFile(string fileId)
        {
            var path = "creating-the-api-and-returning-resources-slides.pdf";
            if(!System.IO.File.Exists(path))
            {
                return NotFound();
            }
            if(!_fileExtensionContentTypeProvider.TryGetContentType(path,out var contentType))
            {
                //if type cannot be determined
                contentType = "application/octet-stream";
            }
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, contentType, Path.GetFileName(path));
        }
    }
}
