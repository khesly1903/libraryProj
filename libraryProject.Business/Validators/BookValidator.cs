﻿using FluentValidation;
using libraryProject.Entities.Models;
namespace libraryProject.Business.Validators;


internal class BookValidator: AbstractValidator<Book>
{
    public BookValidator()
    {
        // BookName boş olamaz
        RuleFor(b => b.BookName)
            .NotEmpty().WithMessage("Kitap adı gereklidir.");

        // BookTitle boş olamaz
        RuleFor(b => b.BookTitle)
            .NotEmpty().WithMessage("Kitap başlığı gereklidir.");

        // BookISBN boş olamaz ve 10 ya da 13 haneli olmalıdır
        RuleFor(b => b.BookISBN)
            .NotEmpty().WithMessage("ISBN gereklidir.")
            .Matches(@"^(?:\d{10}|\d{13})$").WithMessage("ISBN, ya 10 ya da 13 haneli olmalıdır.");

        // TotalCopies 0'dan büyük olmalıdır
        RuleFor(b => b.TotalCopies)
        .GreaterThan(0).WithMessage("Toplam kopya sayısı 0'dan büyük olmalıdır.");


        // Aynı kitap adı veya ISBN ile bir kitap var mı kontrolü
        //RuleFor(b => b)
        //    .Must(book => !bookRepository.BookExists(book.BookName, book.BookISBN))
        //    .WithMessage("Bu kitap adı veya ISBN zaten mevcut.");
    }
}
