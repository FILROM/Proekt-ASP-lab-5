using System;
using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    class GetNoteLisstQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteLisstQueryValidator()
        {
            RuleFor(x => x.UserId).NotEqual(Guid.Empty);
        }
    }
}
