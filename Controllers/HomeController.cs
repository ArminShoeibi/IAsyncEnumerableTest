using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IAsyncEnumerableTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async IAsyncEnumerable<int> GetNumbersFrom0To1000()
        {
            for (int i = 0; i < 1000; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
