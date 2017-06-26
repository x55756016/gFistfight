/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-15                            创建 
 *  
 */
 
using Project.BLL;
using Project.Common.Helper;
using Project.DAL.Database;
using Project.Model;
using Project.UI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;

namespace KMHC.CTMS.UI.Controllers.API
{
    [System.Web.Http.RoutePrefix("api/xy_sp_userspirit")]
    public class xy_sp_userspiritController : ApiController
    {
        private xy_sp_userspiritBLL bll = new xy_sp_userspiritBLL();

        public IHttpActionResult Get(int CurrentPage)
        {
            //申明参数
            int _pageSize = 10;

            try
            {
                PageInfo pageInfo = new PageInfo()
                {
                    PageIndex = CurrentPage,
                    PageSize = _pageSize,
                    OrderField = "UserSpiritID",
                    Order = OrderEnum.asc
                };
                var list = bll.GetList(pageInfo);
                Response<IEnumerable<V_xy_sp_userspirit>> response = new Response<IEnumerable<V_xy_sp_userspirit>>
                {
                    Data = list,
                    PagesCount = pageInfo.Total / _pageSize
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                LogHelper.WriteInfo(ex.ToString());
                return BadRequest("异常");
            }
        }

        public IHttpActionResult GetByUserID(string UserID)
        {
            V_xy_sp_userspirit model = bll.Get(p => p.UserId == UserID);
            return Ok(model);
        }

        public IHttpActionResult Get(string ID)
        {
            V_xy_sp_userspirit model = bll.Get(p=>p.UserSpiritID==ID);
            return Ok(model);
        }

        public IHttpActionResult Post([FromBody]Request<V_xy_sp_userspirit> request)
        {
            V_xy_sp_userspirit model = request.Data as V_xy_sp_userspirit;
            if (string.IsNullOrEmpty(model.UserSpiritID))
            {
                bll.Add(model);
            }
            else
            {
                bll.Edit(model);
            }

            return Ok("ok");
        }

        public IHttpActionResult Delete(string ID)
        {
            bll.Delete(ID);

            return Ok("ok");
        }
        
    }
}
