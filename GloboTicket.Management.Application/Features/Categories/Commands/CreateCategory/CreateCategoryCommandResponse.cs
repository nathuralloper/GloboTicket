using GloboTicket.Management.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse()
            : base()
        {
        }

        public CreateCategoryDto Category { get; set; }
    }
}
