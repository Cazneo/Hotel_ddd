using System;
using Microsoft.AspNetCore.Mvc;
using Payment_API.Model;
using Payment_API.DTOs;
using Payment_API.Services;

[ApiController]
[Route("[controller]")]
public class DeviseController : ControllerBase
{

    private readonly IDeviseService _deviseService;

    public DeviseController(IDeviseService deviseService)
    {
        _deviseService = deviseService;
    }

    [HttpPost("create")]
    public IActionResult CreateDevise([FromBody] DeviseDto deviseDto)
    {

        var newDevise = new Devise
        {
            NomDevise = deviseDto.NomDevise,
            TauxConversionEuro = deviseDto.TauxConversionEuro,
        };


        _deviseService.CreateDeviseAsync(newDevise);


        return Ok(new { deviseId = newDevise.DeviseID});
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var devise = _deviseService.GetDeviseByIdAsync(id);
        if (devise == null)
        {
            return NotFound();
        }
        return Ok(devise);
    }

    [HttpPut("update/{id}")]
    public IActionResult Update(int id, [FromBody] DeviseDto deviseDto)
    {
        var success = _deviseService.UpdateDeviseAsync(id, deviseDto);

        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {
        var success = _deviseService.DeleteDeviseAsync(id);

        return Ok();
    }
    private string GenerateUniqueIdentifier()
    {
        return Guid.NewGuid().ToString();
    }

}
