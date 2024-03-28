using BackEnd.Model.Enuns;
using BackEnd.Model.Request;
using BackEnd.Model.Response;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreteController: ControllerBase
    {
        [HttpGet]
        [Route("obter")]
        public IActionResult ObterFrete([FromQuery] FreteRequest request)
        {
            var distanciaKmTotal = request.Distancia / ValoresAdicionaisFixos.ValorQuilometro;
            var altura = request.Altura;
            var largura = request.Largura;
            var cumprimento = altura * largura * ValoresAdicionaisFixos.ValorMetroCubico;
            var pesoTotal = request.PesoCarga * ValoresAdicionaisFixos.ValorQuilo;

            var response = new FreteResponse();
            //Custo do Frete = (Distância × Valor Fixo por
            //Km) +(Peso × Valor Adicional por Kg) +(Largura × Altura × Valor Adicional por m³)
            response.ValorFrete = distanciaKmTotal + pesoTotal + cumprimento;
            return Ok(response);
        }
    }
}
