using InsuranceApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace InsuranceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class webController : ControllerBase
    {
        public readonly DataDBContext _dataDBContext;

        public webController(DataDBContext DataDBContext)
        {
            _dataDBContext = DataDBContext;
        }

        [HttpGet("{UNIQUEPERSONKEY}")]
        public ActionResult<object> GetByUniquePersonKey(string UNIQUEPERSONKEY)
        {
            if (string.IsNullOrEmpty(UNIQUEPERSONKEY))
            {
                return BadRequest("Invalid UNIQUEPERSONKEY");
            }

        var query = (from p in _dataDBContext.Pharmacy
             join m in _dataDBContext.Member on p.MEMBERNUMBER equals m.UNIQUEPERSONKEY into memberGroup
             from m in memberGroup.DefaultIfEmpty()
             join pr in _dataDBContext.Provider on p.PROVIDERID equals pr.PROVIDERID into providerGroup
             from pr in providerGroup.DefaultIfEmpty()
             where m.UNIQUEPERSONKEY == UNIQUEPERSONKEY
             select new
             {
                 Date = p.RXFILLDATE,
                 Quantity = p.QUANTITY,
                 ProviderFullName = $"{pr.FIRSTNAME} {pr.MIDDLEINITIAL} {pr.LASTNAME}",
                 SpecialtyCode = pr.HPSPECIALITYCODE1,
                 Member = new
                 {
                     MemberUniquePersonKey = m.UNIQUEPERSONKEY,
                     MemberLastName = m.LASTNAME,
                     MemberFirstName = m.FIRSTNAME,
                     MemberDate = m.DATEOFBIRTH,
                     memberGender = m.GENDER,
                     memberPhone = m.TELEPHONENUMBER,
                     memberaddress = m.PERMANENTADDRESSLINE1,
                     membercity = m.PERMANENTCITY,
                     memberstate = m.PERMANENTSTATE
                     // Add other member properties as needed
                 }
             }).ToList();


            var data = query;







            if (data == null)
            {
                return NotFound("Data not found");
            }

            return Ok(data);
        }

        [HttpDelete("{UNIQUEPERSONKEY}")]
        public IActionResult DeleteByUniquePersonKey(string UNIQUEPERSONKEY)
        {
            if (string.IsNullOrEmpty(UNIQUEPERSONKEY))
            {
                return BadRequest("UNIQUEPERSONKEY is required.");
            }

            var res = _dataDBContext.Member.FirstOrDefault(a => a.UNIQUEPERSONKEY == UNIQUEPERSONKEY);
            if (res != null)
            {
                _dataDBContext.Remove(res);
                _dataDBContext.SaveChanges();
                return Ok();
            }
            return BadRequest("No");
        }




    }
}
