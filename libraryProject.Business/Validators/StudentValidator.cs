﻿using FluentValidation;
using libraryProject.Entities.Models;


namespace libraryProject.Business.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            
            RuleFor(s => s.StudentName)
              .NotEmpty().WithMessage("Öğrenci adı zorunludur.")
              .Matches(@"^[a-zA-ZÇİÜĞŞÖçüğşöı\s]+$").WithMessage("Öğrenci adı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(s => s.StudentSurname)
               .NotEmpty().WithMessage("Öğrenci soyadı zorunludur.")
               .Matches(@"^[a-zA-ZÇİÜĞŞÖçüğşöı\s]+$").WithMessage("Öğrenci soyadı sadece harf içerebilir, sayı ve özel karakter içeremez.");

            RuleFor(s => s.StudentNumber)
            .NotEmpty().WithMessage("Öğrenci numarası zorunludur.")
            .Matches(@"^\d+$").WithMessage("Öğrenci numarası sadece sayılardan oluşmalıdır.")
            .Length(10).WithMessage("Öğrenci numarası 10 haneli olmalıdır");
            

        }

    }
}
