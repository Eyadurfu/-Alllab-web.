function tabClick(event) {
  const path = event.currentTarget.dataset.path
  const tabSection = document.querySelector('.as-we-work')

  // Назначение активной кнопки таба
  tabSection.querySelector('button.as-we-work__step-button--active').classList.remove('as-we-work__step-button--active')
  event.currentTarget.classList.add('as-we-work__step-button--active')

  // Назначение активного таба
  tabSection.querySelectorAll('.as-we-work__content').forEach(tab => {
    if (tab.dataset.path == path) {
      tab.classList.add('tab-active')
    } else {
      tab.classList.remove('tab-active')
    }
  })
}


(function addTabListener() {
  Array.from(document.querySelectorAll('.as-we-work__step-button')).forEach(btn => btn.addEventListener('click', tabClick))
}())
