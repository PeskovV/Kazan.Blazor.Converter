using BlazorApp.Wasm.Dtos;

namespace BlazorApp.Wasm.Services;

public interface ISpaceXService
{
    Task<LaunchDto[]?> GetAllLaunches();
}