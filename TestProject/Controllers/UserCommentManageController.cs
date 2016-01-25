using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using TestProject.Models.ViewModels;
using TestProject.Models.DBModels;
using TestProject.Models.DBContext;

namespace TestProject.Controllers
{
    public class UserCommentManageController : ApiController
    {
        private DatabaseContext _db = new DatabaseContext();

        public async Task<IHttpActionResult> Post(UserComment commnet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PlaceComment PlaceComment = new PlaceComment();
            PlaceComment.Id = Guid.NewGuid();
            PlaceComment.PlaceId = new Guid("dac11b39-c8a9-4c7f-9324-b626d8d61076");
            PlaceComment.Comment = commnet.Comment;

            _db.PlaceCommens.Add(PlaceComment);
            try {
                await _db.SaveChangesAsync();
                return Ok(commnet);
            }
            catch ( Exception e)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError,e));
            }

            
        }

    }
}
