using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_rpg.Services
{
    public interface ICharacterService 
    {
        Task<ServiceResponse<List<CharacterResponseDto>>> GetAllCharactersAsync();
        Task<ServiceResponse<CharacterResponseDto?>> GetCharacterByIdAsync(int Id);
        Task<ServiceResponse<CharacterResponseDto>> AddCharacterAsync(AddCharacterDto newCharacter);
        Task<ServiceResponse<CharacterResponseDto?>> UpdatedCharacterAsync(UpdateCharacterDto updatedCharacter, int Id);
        Task<ServiceResponse<CharacterResponseDto?>> DeleteCharacterAsync(int id);
    }
}