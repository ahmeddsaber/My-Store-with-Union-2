using Mapster;
using MyStore.DTO.CategoryDTO;
using MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Application.Mapper
{
    public class MapsterConfig
    {
public static void RegisterMapsterConfiguration()
        {
            TypeAdapterConfig<Catagory, CategoryDTO>
                .NewConfig().Map(des => des.CatId, src => src.Id)
                .Map(dest => dest.CatName, src => src.Name)
                .Map(dest => dest.CatDisc, src => src.Description);
            TypeAdapterConfig<CreateCategoryDTOs, Catagory>.NewConfig();
               
        }
    }
}
