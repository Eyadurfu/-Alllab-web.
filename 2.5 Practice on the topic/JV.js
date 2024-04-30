document.addEventListener('DOMContentLoaded', function() {
    const bookTitleElement = document.getElementById('bookTitle');
    const bookCardElement = document.getElementById('bookCard');
  
    bookTitleElement.textContent = 'По стопам Господа | Айлс Грег';
  
    bookCardElement.classList.add('card');
    bookTitleElement.classList.add('card-title');
  
    const cardTextElements = document.querySelectorAll('.card-text');
    cardTextElements.forEach(element => {
      element.classList.add('card-text');
    });
  
    const cardImageElement = document.querySelector('.card-image');
    cardImageElement.classList.add('card-image');
  });
  
