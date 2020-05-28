using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RoarcoderUserInfoApi.Models;

namespace RoarcoderUserInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly UserInfoContext _context;

        public UserInfoController(UserInfoContext context)
        {
            _context = context;
        }

        // GET: api/UserInfo
        [HttpGet]
        public ActionResult<List<UserInfo>> GetAll()
        {
            return _context.UserInfo.ToList();
        }

        // GET: api/UserInfo/5
        [HttpGet("{id}")]
        public ActionResult<UserInfo> GetUserInfo(long id)
        {
            var userInfo = _context.UserInfo.Find(id);

            if (userInfo == null)
            {
                return NotFound();
            }

            return userInfo;
        }

        [HttpPost]
        public void Post([FromBody] UserInfo userInfo)
        {
            _context.Add(userInfo);

            _context.SaveChanges();
        }


    }
}
