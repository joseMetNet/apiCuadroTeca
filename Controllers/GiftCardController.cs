﻿using fotoTeca.Models.GiftCard;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fotoTeca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GiftCardController : ControllerBase
    {
        private readonly GiftCardDAL _repository1;

        public GiftCardController(GiftCardDAL repository1)
        {

            _repository1 = repository1 ?? throw new ArgumentNullException(nameof(repository1));

        }

        //POST------------------------------------------------------------------------------------------------

        [HttpPost("/storeOrUpdateGiftCard", Name = "storeOrUpdateGiftCard")]
        public async Task<List<GiftCarResponse>> post1(GiftCarResqueride user)
        {
            return await _repository1.storeOrUpdateGiftCard(user);
        }
        //GET-------------------------------------------------------------------------------------------------
        [HttpGet("/GetGiftCard")]
        public async Task<List<GiftCarResponse2>> get1()
        {
            return await _repository1.GetGiftCard();

        }
        [HttpGet("/GetGiftCard/{idGiftCard}")]
        public async Task<List<GiftCarResponse2>> get2(int idGiftCard)
        {
            return await _repository1.GetGiftCard(idGiftCard);
        }
        //DELETE------------------------------------------------------------------------------------------------
        [HttpDelete("DeleteClient/{idGiftCard}", Name = "DeleteClient")]
        public async Task Delete(int idGiftCard)

        {
            await _repository1.DeleteGiftCard(idGiftCard);
        }
        //UPDATE-------------------------------------------------------------------------------------------------
        [HttpPut("UpdateGiftCard", Name = "UpdateGiftCard")]
        public async Task put3([FromBody] GiftCarStatusResqueride apu)

        {
            await _repository1.UpdateGiftCard(apu);
        }
    }
}