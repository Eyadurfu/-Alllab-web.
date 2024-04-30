function startSwiper() {
  swiper = new Swiper('.swiper', {
    speed: 1000,
    slidesPerView: 'auto',
    loop: true,

    autoplay: {
      delay: 5000,
    },

    pagination: {
      el: '.swiper-pagination',
      clickable: true,
    },
  })
}

document.addEventListener('DOMContentLoaded', startSwiper)
