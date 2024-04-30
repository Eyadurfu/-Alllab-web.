(() => {
  const openButton = document.querySelector('.header__mobile-menu-button')
  const closeButton = document.querySelector('.mobile-menu__close-button')
  const mobileMenu = document.querySelector('.mobile-menu')

  const openClass = 'mobile-menu--is-active'

  const openMenu = () => {
    mobileMenu.classList.add(openClass)
  }
  const closeMenu = () => {
    mobileMenu.classList.remove(openClass)
  }

  openButton.addEventListener('click', openMenu)
  closeButton.addEventListener('click', closeMenu)
})()
