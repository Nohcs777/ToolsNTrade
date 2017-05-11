/*
 * TNT Cardstore
 *
 * This is a sample server Cardstore service.  You can find  out more about Swagger at  [http://swagger.io](http://swagger.io) or on  [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.1
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CardApiController : Controller
    { 

        /// <summary>
        /// Add a new Card to the store
        /// </summary>
        
        /// <param name="body">Card object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card")]
        [SwaggerOperation("AddCard")]
        public virtual void AddCard([FromBody]Card body)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Deletes a Card
        /// </summary>
        
        /// <param name="cardId">Card id to delete</param>
        /// <param name="apiKey"></param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Card not found</response>
        [HttpDelete]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/{CardId}")]
        [SwaggerOperation("DeleteCard")]
        public virtual void DeleteCard([FromRoute]long? cardId, [FromHeader]string apiKey)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Finds Cards by status
        /// </summary>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/findByStatus")]
        [SwaggerOperation("FindCardsByStatus")]
        [SwaggerResponse(200, type: typeof(List<Card>))]
        public virtual IActionResult FindCardsByStatus([FromQuery]List<string> status)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Card>>(exampleJson)
            : default(List<Card>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Finds Cards by tags
        /// </summary>
        /// <remarks>Muliple tags can be provided with comma separated strings. Use\\ \\ tag1, tag2, tag3 for testing.</remarks>
        /// <param name="tags">Tags to filter by</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/findByTags")]
        [SwaggerOperation("FindCardsByTags")]
        [SwaggerResponse(200, type: typeof(List<Card>))]
        public virtual IActionResult FindCardsByTags([FromQuery]List<string> tags)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Card>>(exampleJson)
            : default(List<Card>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Find Card by ID
        /// </summary>
        /// <remarks>Returns a single Card</remarks>
        /// <param name="cardId">ID of Card to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Card not found</response>
        [HttpGet]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/{CardId}")]
        [SwaggerOperation("GetCardById")]
        [SwaggerResponse(200, type: typeof(Card))]
        public virtual IActionResult GetCardById([FromRoute]long? cardId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Card>(exampleJson)
            : default(Card);
            return new ObjectResult(example);
        }


        /// <summary>
        /// Update an existing Card
        /// </summary>
        
        /// <param name="body">Card object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Card not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card")]
        [SwaggerOperation("UpdateCard")]
        public virtual void UpdateCard([FromBody]Card body)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Updates a Card in the store with form data
        /// </summary>
        
        /// <param name="cardId">ID of Card that needs to be updated</param>
        /// <param name="name">Updated name of the Card</param>
        /// <param name="status">Updated status of the Card</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/{CardId}")]
        [SwaggerOperation("UpdateCardWithForm")]
        public virtual void UpdateCardWithForm([FromRoute]long? cardId, [FromForm]string name, [FromForm]string status)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// uploads an image
        /// </summary>
        
        /// <param name="cardId">ID of Card to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server</param>
        /// <param name="file">file to upload</param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/ToolsNTrade/Cardstore/1.0.0/Card/{CardId}/uploadImage")]
        [SwaggerOperation("UploadFile")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult UploadFile([FromRoute]long? cardId, [FromForm]string additionalMetadata, [FromForm]System.IO.Stream file)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }
    }
}
