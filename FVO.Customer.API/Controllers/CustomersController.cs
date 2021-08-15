using FVO.Customer.API.Option1.Models;
using FVO.Customer.API.Option2.Models;
using FVO.Customer.API.Option3.Models;
using FVO.Customer.API.Option4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FVO.Customer.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        // POST api/customers/op1
        /// <summary>
        /// Opção 1 - Validação interna no Input Model (ideal para retornar um Custom Response)
        /// </summary>   
        /// <remarks>
        /// Exemplo request:
        ///
        ///     POST / Customer
        ///     {
        ///         "name": "Mario Silva",
        ///         "dateBirth": "2021-08-14T22:06:19.232Z",
        ///         "rg": "12.345.678-9",
        ///         "cpf": "123.456.789-10"
        ///     }
        /// </remarks>        
        [HttpPost("op1")]
        [ActionName("NewCustomerOption1")]
        public async Task<IActionResult> PostAsyncOption1([FromBody] CustomerInputModelOption1 model)
        {
            if (!model.Validate()) return BadRequest(model.ValidationResult);  // return CustomResponde(model.ValidationResult)

            return CreatedAtAction("NewCustomerOption1", new { id = 1 }, model);
        }

        // POST api/customers/op2
        /// <summary>
        /// Opção 2 - Validação através de um arquivo Validator
        /// </summary>   
        /// <remarks>
        /// Exemplo request:
        ///
        ///     POST / Customer
        ///     {
        ///         "name": "Mario Silva",
        ///         "dateBirth": "2021-08-14T22:06:19.232Z",
        ///         "rg": "12.345.678-9",
        ///         "cpf": "123.456.789-10"
        ///     }
        /// </remarks>        
        [HttpPost("op2")]
        [ActionName("NewCustomerOption2")]
        public async Task<IActionResult> PostAsyncOption2([FromBody] CustomerInputModelOption2 model)
        {
            return CreatedAtAction("NewCustomerOption2", new { id = 1 }, model);
        }

        // POST api/customers/op3
        /// <summary>
        /// Opção 3 - Validação através de um Action Filter em conjunto com um arquivo Validator (Retorna só as mensagens de erro)
        /// </summary>   
        /// <remarks>
        /// Exemplo request:
        ///
        ///     POST / Customer
        ///     {
        ///         "name": "Mario Silva",
        ///         "dateBirth": "2021-08-14T22:06:19.232Z",
        ///         "rg": "12.345.678-9",
        ///         "cpf": "123.456.789-10"
        ///     }
        /// </remarks>        
        [HttpPost("op3")]
        [ActionName("NewCustomerOption3")]
        public async Task<IActionResult> PostAsyncOption3([FromBody] CustomerInputModelOption3 model)
        {
            return CreatedAtAction("NewCustomerOption3", new { id = 1 }, model);
        }

        // POST api/customers/op4
        /// <summary>
        /// Opção 4 - Validação através de Data Annotations
        /// </summary>   
        /// <remarks>
        /// Exemplo request:
        ///
        ///     POST / Customer
        ///     {
        ///         "name": "Mario Silva",
        ///         "dateBirth": "2021-08-14T22:06:19.232Z",
        ///         "rg": "12.345.678-9",
        ///         "cpf": "123.456.789-10"
        ///     }
        /// </remarks>        
        [HttpPost("op4")]
        [ActionName("NewCustomerOption4")]
        public async Task<IActionResult> PostAsyncOption4([FromBody] CustomerInputModelOption4 model)
        {
            return CreatedAtAction("NewCustomerOption4", new { id = 1 }, model);
        }

    }
}
