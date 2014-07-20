define(['book'], function (Book) {
    var booksData = [];

    booksData.push(new Book('The Green Mile', 'Stephen King'));
    booksData.push(new Book('Pod Igoto', 'Ivan Vazov'));
    booksData.push(new Book('Nemili nedragi', 'Ivan Vazov'));
    booksData.push(new Book('Harry Potter', 'J.K. Rowling'));
    booksData.push(new Book('Black House', 'Stephen King'));
    booksData.push(new Book('Hearts In Atlantis', 'Stephen King'));

    return booksData;
})