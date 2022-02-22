using System;
using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNotesDetailsValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNotesDetailsValidator()
        {
            RuleFor(note => note.Id).NotEqual(Guid.Empty);
            RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
            
             
       
    }
}
