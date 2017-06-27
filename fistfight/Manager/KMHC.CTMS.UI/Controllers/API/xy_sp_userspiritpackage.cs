﻿/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2017-06-27                            创建 
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
    [System.Web.Http.RoutePrefix("api/xy_sp_userspiritpackage")]
    public class xy_sp_userspiritpackageController : ApiController
    {
        private xy_sp_userspiritpackageBLL bll = new xy_sp_userspiritpackageBLL();

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
                    OrderField = "SpiritPackageID",
                    Order = OrderEnum.asc
                };
                var list = bll.GetList(pageInfo);
                Response<IEnumerable<V_xy_sp_userspiritpackage>> response = new Response<IEnumerable<V_xy_sp_userspiritpackage>>
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

        public IHttpActionResult Get(string ID)
        {
            V_xy_sp_userspiritpackage model = bll.Get(p=>p.SpiritPackageID==ID);
            return Ok(model);
        }

        public IHttpActionResult Post([FromBody]Request<V_xy_sp_userspiritpackage> request)
        {
            V_xy_sp_userspiritpackage model = request.Data as V_xy_sp_userspiritpackage;
            if (string.IsNullOrEmpty(model.SpiritPackageID))
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