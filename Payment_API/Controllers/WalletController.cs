// WalletController.cs
using Microsoft.AspNetCore.Mvc;
using Payment_API.DTOs;
using Payment_API.Model;
using Payment_API.Services;

[ApiController]
[Route("[controller]")]
public class WalletController : ControllerBase
{
    private readonly IWalletService _walletService;

    public WalletController(IWalletService walletService)
    {
        _walletService = walletService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var wallet = await _walletService.GetWalletByIdAsync(id);
        if (wallet == null)
        {
            return NotFound();
        }
        return Ok(wallet);
    }
    [HttpPost("create")]
    public async Task<IActionResult> CreateWalletAsync([FromBody] WalletDto walletDto)
    {
        var wallet = new Wallet
        {
            WalletID= walletDto.WalletID,
            UserID= walletDto.UserID,
            DeviseID= walletDto.DeviseID,
            Montant= walletDto.Montant,
            
            
        };

        await _walletService.CreateWalletAsync(wallet);

        return CreatedAtAction(nameof(Get), new { id = wallet.WalletID }, wallet);
    }



    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateWalletAsync(int id, [FromBody] WalletDto walletDto)
    {
        var success = await _walletService.UpdateWalletAsync(id, walletDto);
        if (!success)
        {
            return NotFound();
        }

        return NoContent(); // 204 No Content
    }


    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteWalletAsync(int id)
    {
        var success = await _walletService.DeleteWalletAsync(id);
        if (!success)
        {
            return NotFound();
        }

        return NoContent(); // 204 No Content
    }

}
