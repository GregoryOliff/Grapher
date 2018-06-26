using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Grapher.Api.Models;

namespace Grapher.Api.Controllers
{
    [Route("[controller]")]
    public class GraphQLController : Controller
    {
        private readonly IDocumentExecutioner _documentExecutioner;
        private readonly ISchema _schema;

        public GraphQLController(ISchema schema, IDocumentExecutioner documentExecutioner)
        {
            _schema = schema;
            _documentExecutioner = documentExecutioner;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery guery)
        {
            If(GraphQLQuery == null) {
                throw new ArgumentNullException(nameof(query)); 
            }

            var inputs = query.Variables.ToInputs();
            var executionOptions = new ExecutionOptions
            {
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs
            };

            var result = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);

            if (result.Errors?.count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}