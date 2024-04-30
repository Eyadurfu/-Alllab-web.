/* montserrat-regular - latin_cyrillic */
@font-face {
  font-family: 'Montserrat';
  font-style: normal;
  font-weight: 400;
  src: local(''),
       url('../fonts/montserrat-v15-latin_cyrillic-regular.woff2') format('woff2'),
       url('../fonts/montserrat-v15-latin_cyrillic-regular.woff') format('woff');
}
/* montserrat-600*/
@font-face {
  font-family: 'Montserrat';
  font-style: normal;
  font-weight: 600;
  font-display: swap;
  src: local('Montserrat'),
       url('../fonts/montserrat-v15-latin_cyrillic-600.woff2') format('woff2'),
       url('../fonts/montserrat-v15-latin_cyrillic-600.woff') format('woff');
}
/* montserrat-700*/
@font-face {
  font-family: 'Montserrat';
  font-style: normal;
  font-weight: 700;
  font-display: swap;
  src: local('Montserrat'),
       url('../fonts/montserrat-v15-latin_cyrillic-700.woff2') format('woff2'),
       url('../fonts/montserrat-v15-latin_cyrillic-700.woff') format('woff');
}
/* montserrat-800*/
@font-face {
  font-family: 'Montserrat';
  font-style: normal;
  font-weight: 800;
  font-display: swap;
  src: local('Montserrat'),
       url('../fonts/montserrat-v15-latin_cyrillic-800.woff2') format('woff2'),
       url('../fonts/montserrat-v15-latin_cyrillic-800.woff') format('woff');
}

/* Global */
:root {
  --primary-color: #FF9900;
  --swiper-pagination-bullet-size: 15px;
  --swiper-pagination-bullet-margin-bottom: 30px;
  --swiper-pagination-bullet-horizontal-gap: 10px;
  --swiper-theme-color: #fff;
  --swiper-pagination-bullet-inactive-color: #fff;
  --swiper-pagination-bullet-inactive-opacity: 0.4;
  --question-space: 39px;
  --label-padding-top: 5px;
}

* {
  box-sizing: border-box;
}

* {
  -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}

.index-body {
  margin: 0px;
}

.index-a {
  text-decoration: none;
  color: inherit;
}

.index-ul {
  margin: 0;
  padding: 0;
  list-style: none;
}

.index-p {
  margin: 0px;
}

.order__heading {
  margin: 0px;
}

.index-h2 {
  margin: 0px;
}

.index-h3 {
  margin: 0px;
}

img {
  max-width: 100%;
}

.container {
  max-width: 1920px;
  margin: 0px auto;
  padding: 0px 75px;
}

/* Fonts */
.index-body {
  font-family: Montserrat, sans-serif;
  font-weight: 400;
  font-size: 16px;
}

.header-nav__list {
  font-weight: 600;
  font-size: 18px;
}

.order__heading {
  font-weight: 800;
  font-size: 70px;
  line-height: 85.33px;
}

.order__description {
  font-weight: 700;
  font-size: 24px;
  line-height: 29px;
}

.button {
  font-weight: 700;
  font-size: 23.46px;
}

.section-heading {
  font-weight: 400;
  font-size: 48px;
  line-height: 58.51px;
}

.about__text {
  line-height: 32px;
}

.card-big__text {
  font-weight: 700;
  line-height: 32px;
}

.button--section-about {
  font-size: 16px;
}

.card-small__heading {
  font-weight: 700;
  font-size: 24px;
  line-height: 29.26px;
}

.card-small__text {
  line-height: 32px;
}

.as-we-work__step-button {
  font-family: inherit;
  font-size: 18px;
}

.as-we-work__heading {
  font-weight: 700;
  font-size: 24px;
  line-height: 32px;
}

.as-we-work__text-content {
  line-height: 32px;
}

.as-we-work__more {
  font-size: 16px;
  line-height: 19.5px;
}

.as-we-work__offer {
  font-weight: 400;
  font-size: 16px;
  line-height: 19.5px;
}

.question__heading {
  font-weight: 700;
  font-size: 24px;
  line-height: 32px;
}

.footer-nav__list {
  font-weight: 600;
  font-size: 18px;
  line-height: 36px;
}

.application-form {
  line-height: 32px;
}

.application-form__heading {
  font-weight: 400;
  font-size: 48px;
}

.application-form__button {
  font-size: 16px;
  line-height: 19.5px;
  font-family: Montserrat;
}

.footer__text {
  line-height: 32px;
}

/* header */
.index-header {
  position: fixed;
  width: 100vw;
  top: 0px;
  left: 0px;
  box-shadow: 0px 5px 40px rgba(0, 0, 0, 0.1);
  z-index: 100;
}

.header__container {
  display: flex;
  padding-top: 14px;
  padding-bottom: 14px;
  flex-wrap: wrap;
  align-items: center;
  background-color: white;
}

.burger-button {
  display: none;
  padding: 0px;
  margin: 0px;
  border: none;
  background-color: transparent;
}

.burger-button__img {
  width: 30px;
  height: 23px
}

.mobile-menu {
  position: absolute;
  display: none;
  top: 0px;
  left: 0px;
  padding: 39px 50px;
  min-width: 420px;
  min-height: 768px;
  background-color: white;
  box-shadow: 0px 5px 40px rgba(0, 0, 0, 0.1);
}

.mobile-menu__close-button {
  width: 23px;
  height: 23px;
  padding: 0px;
  margin: 0px;
  margin-bottom: 100px;
  background-color: transparent;
  border: none;
}

.mobile-menu__nav-list {
  list-style: none;
  padding: 0px;
  margin: 0px;
  font-weight: 700;
  font-size: 24px;
}

.mobile-menu__nav-item:not(:last-child) {
  margin-bottom: 60px;
}

.mobile-menu__nav-link {
  line-height: 29.26px;
}

.header-nav {
  margin-left: auto;
  max-width: 80%;
}

.header-nav__list {
  display: flex;
  margin-right: 77px;
  margin-bottom: -5px;
  flex-wrap: wrap;
}

.header-nav__items:not(:last-child) {
  margin-right: 85.5px;
}

.header-nav__items {
  margin-bottom: 5px;
}

.header-nav__link {
  border-bottom: 2px solid transparent;
  margin-bottom: -2px;
  transition-property: color, border-color;
  transition-duration: .2s;
}

.header__search-container {
  position: relative;
  height: 32px;
  width: 32px;
}

.header__search-button {
  padding: 4px;
  padding-bottom: 0px;
  border-bottom: 4px solid transparent;
  background: inherit;
  border: none;
  cursor: pointer;
  color: #333333;
  transition-property: color;
  transition-duration: .2s;
}

.header__search-button-img {
  width: 24px;
  height: 24px;
}

.header__search {
  width: 100%;
  height: 100%;
}

.header__search-form-container {
  position: absolute;
  top: 0;
  right: -13px;
  transform: translateY(-25%);
  display: none;
  justify-content: space-between;
  align-items: center;
  padding: 13px;
  max-width: 539px;
  height: 60px;
  background-color: white;
  border-radius: 16px;
  box-shadow: 0px 0px 20px rgba(0, 0, 0, 0.12);
}

.header__search-form {
  display: flex;
  align-items: center;
  margin-left: 19px;
  margin-right: 20px;
}

.header__search-input {
  margin-right: 14px;
  padding: 0;
  padding-bottom: 10px;
  width: 412px;
  border: none;
  border-bottom: 1px solid #DCDCDC;
  font-size: 18px;
  font-weight: 500;
}

/* ------ Скрытие крестика у инпута ----- */
input[type=text]::-ms-clear {  display: none; width : 0; height: 0; }
input[type=text]::-ms-reveal {  display: none; width : 0; height: 0; }
input[type="search"]::-webkit-search-decoration,
input[type="search"]::-webkit-search-cancel-button,
input[type="search"]::-webkit-search-results-button,
input[type="search"]::-webkit-search-results-decoration { display: none; }

.header__search-submit {
  padding: 0;
  width: 24px;
  height: 24px;
  background-color: transparent;
  border: none;
}

.header__search-submit-img {
  max-width: 100%;
  max-height: 100%;
}

.header__search-close {
  padding: 0;
  width: 24px;
  height: 24px;
  border: none;
  background: transparent;
}

.header__search-close-img {
  width: 100%;
  height: 100%;
}

/* Order */
.order {
  margin-top: 100px;
  padding-bottom: 50px;
}

.order__wrapper {
  position: relative;
  padding: 101px 81px;
  color: white;
  background-size: cover;
  pointer-events: none;
}

.order__order-payment {
  pointer-events: auto;
}

.order__content {
  max-width: 837px;
}

.order__heading {
  margin-bottom: 23px;
}

.order__description {
  margin-bottom: 91.4px;
  line-height: 29.26px;
}

.order__order-payment {
  display: inline-block;
  padding: 24.5px 36.88px;
  margin-bottom: 0.1px;
  transition-property: background-color;
  transition-duration: .2s;
}

.swiper-wrapper {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: -1;
}

/* Swiper */
.swiper-pagination {
  z-index: 10;
}

.swiper-button-next {
  z-index: 1000;
}

.swiper-horizontal>
.swiper-pagination-bullets,
.swiper-pagination-bullets
.swiper-pagination-horizontal,
.swiper-pagination-custom,
.swiper-pagination-fraction {
  bottom: var(--swiper-pagination-bullet-margin-bottom);
}

.swiper-pagination-bullet:focus {
  outline: 2px solid var(--primary-color)
}

.order__background {
  width: 100%;
  height: 100%;
  background-repeat: no-repeat;
  background-size: cover;
}

.order__background--1 {
  background-image: url("../pictures/low-angle-photo-of-balconies-2462015\ 1.jpg");
}

.order__background--2 {
  background-image: url("../pictures/brown-and-blue-glass-building.jpg");
}

.order__background--3 {
  background-image: url("../pictures/gray-building.jpg");
}

.button--orange {
  color: white;
  background: var(--primary-color);
}

/* About */
.about {
  padding-top: 52px;
  padding-bottom: 50px;
}

.about__heading {
  margin-bottom: 11px;
  padding-left: 2px;
}

.about__text {
  max-width: 1235px;
  margin-bottom: 49px;
  line-height: 32px;
}

.about__cards {
  display: flex;
  justify-content: space-between;
}

.about__cards-wrapper--big {
  width: 49.03%;
}

.about__cards-wrapper--small {
  width: 49.1%;
}

.about-card {
  background-repeat: no-repeat;
}

.card-big {
  display: flex;
  flex-direction: column-reverse;
  min-height: 100%;
  color: white;
}

.card-big__content {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 0px 5.7%;
  padding-top: 51px;
  padding-bottom: 49px;
  background: rgba(0, 0, 0, 0.5);
}

.card-big__text {
  max-width: 454px;
  padding-left: 1px;
  margin-right: 20px;
}

.about-card__mobile-img {
  display: none;
  width: 100%;
  margin-bottom: 8px;
}

.button--section-about {
  max-width: 175px;
  max-height: 60px;
  color: white;
  padding-top: 19px;
  padding-bottom: 21px;
  padding-left: 35px;
  padding-right: 40px;
  border: 3px solid var(--primary-color);
  transition-property: background-color, border-color;
  transition-duration: .2s;
}

.about-card--bilder {
  background: url(../pictures/bilder.jpg);
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
}

.card-small {
  min-height: 295px;
  padding: 65px 12% 35px 34.4%;
  border: 1px solid #CACACA;
  background-repeat: no-repeat;
  background-position: 8.7% center;
  background-size: 21.8%;
}

.card-small:not(:last-child) {
  margin-bottom: 32px;
}

.card-small__heading {
  margin-bottom: 8px;
}

.about-card--circle-cube {
  background-image: url(../pictures/circle-with-cube.svg);
}

.about-card--circle-setting {
  background-image: url(../pictures/circle-with-settings.svg);
}

/* As we work */
.as-we-work {
  padding-top: 51px;
  padding-bottom: 50px;
}

.as-we-work__heading {
  margin-bottom: 51px;
  font-weight: 400;
  font-size: 48px;
  line-height: 58.51px;
}

.as-we-work__btn-step-list {
  display: flex;
  justify-content: space-between;
  max-width: 462px;
  margin-bottom: 47px;
  padding-left: 0px;
  flex-wrap: wrap;
}

.as-we-work__step-button {
  padding: 0px;
  background-color: inherit;
  border: none;
  cursor: pointer;
  transition-property: color;
  transition-duration: .2s;
}

.as-we-work__step-button--active {
  color: #E1670E;
  outline: none !important;
  border-color: transparent !important;
}

.orange-text {
  color: #E1670E;
}

.as-we-work__content {
  display: none;
  flex-direction: column;
  justify-content: space-between;
  position: relative;
  width: 42.82%;
  min-height: 472px;
}

.tab-active {
  display: flex;
}

.as-we-work__content::after {
  content: '';
  position: absolute;
  left: 119%;
  bottom: 0px;
  width: 114.77%;
  height: calc(100% - 10px);
  margin-bottom: 0px;
  background: left bottom no-repeat;
  background-size: cover;
}

.as-we-work__content--consultation::after {
  background-image: url("../pictures/consultation.jpg");
}

.as-we-work__content--make-estimate::after {
  background-image: url(/pictures/cost-estimate.jpg)
}

.as-we-work__content--atract-contractors::after {
  background-image: url(/pictures/bring-contractor.jpg)
}

.as-we-work__content--inspecting::after {
  background-image: url(/pictures/inspecting-works.jpg)
}

.as-we-work__content-heading {
  margin-bottom: 7.8px;
  font-size: 24px;
  font-weight: 700;
  line-height: 32px;
}

.as-we-work__text-content {
  margin-bottom: 50px;
}

.as-we-work__background-img {
  width: 49.15%;
  margin-top: 10px;
  margin-bottom: 0px;
  background: url(../pictures/consultation.jpg) left bottom no-repeat;
  background-size: cover;
}

.as-we-work__button-group {
  margin-top: -15px;
}

.as-we-work__more {
  display: inline-block;
  padding: 20px 38px;
  margin-right: 29px;
  margin-top: 15px;
  line-height: 20px;
  transition-property: background-color;
  transition-duration: .2s;
}

.as-we-work__offer {
  display: inline-block;
  padding: 20px 37px;
  margin-top: 15px;
  border: 1px solid #333333;
  transition-property: color, background-color, border-color;
  transition-duration: .2s;
}

/* Questions */
.questions {
  padding-top: 50px;
  padding-bottom: 100px;
}

.questions-heading {
  margin-bottom: 45px;
  line-height: 58.51px;
}

.questions__list {
  padding-left: 0px;
}

.question:first-child {
  border-top: 1px solid #CACACA;
}

.question {
  margin-top: -1px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid #CACACA;
  cursor: pointer;
  transition-property: color, border-color;
  transition-duration: .3s;
}

.question--small-padding {
  --question-space: 30px;
}

.question__heading {
  position: relative;
  padding: var(--question-space) 0px;
  padding-right: 80px;
}

.gray-slash {
  color: #CACACA;
}

.question__icon {
  position: absolute;
  width: 50px;
  height: 50px;
  top: 50%;
  transform: translateY(-50%);
  right: 0px;
  background-color: #ECECEC;
  border-radius: 50%;
  transition-property: background-color, transform;
  transition-duration: .3s;
}

.question__icon::after {
  content: "";
  position: absolute;
  top: 50%;
  left: 50%;
  width: 60%;
  height: .1px;
  transform: translate(-50%, -50%);
  background-color: #666666;
  transition-property: background-color;
  transition-duration: .3s;
}

.question__icon::before {
  content: "";
  position: absolute;
  top: 50%;
  left: 50%;
  height: 60%;
  width: .1px;
  transform: translate(-50%, -50%);
  background-color: rgba(102, 102, 102, 1);
  transition-property: background-color;
  transition-duration: .3s;
}

.question__answer {
  line-height: 32px;
  color: black;
}

.question__answer:not(:last-child) {
  margin-bottom: var(--question-space);
}

.question__answer-wrapper {
  max-width: 1000px;
  padding-bottom: var(--question-space);
  /* margin-bottom: 40px; */
}

/* Footer */
.index-footer {
  padding-top: 50px;
  padding-bottom: 50px;
  background: #222222;
}

.index-footer-container {
  display: flex;
  justify-content: space-between;
}

.index-footer__left {
  max-width: 252px;
}

.index-footer__logo {
  margin-bottom: 15px;
}

.footer-nav__list {
  padding: 0;
  margin-bottom: 90px;
  color: #CACACA;
}

.footer-nav__link {
  transition-property: color;
  transition-duration: .2s;
}

.index-footer__social-link-group {
  display: flex;
  padding: 0px;
  max-width: 230px;
  max-height: 60px;
  justify-content: space-between;
}

.social-link__img {
  width: 100%;
  height: 100%;
}

.index-footer__social-link-color {
  transition-property: fill;
  transition-duration: .2s;
}

.index-footer__center {
  min-width: 570px;
  margin-left: 7.6%;
  color: #CACACA;
}

.application-form {
  display: flex;
  min-height: 464px;
  flex-direction: column;
}

.application-form__heading {
  margin-bottom: 25px;
  line-height: 58.51px;
}

.application-form__input {
  padding: 24px;
  margin-bottom: 25px;
  background-color: #414141;
  border: none;
  color:white;
  font-family: Montserrat;
  font-size: 16px;
  line-height: 32px;
  transition-property: background-color;
  transition-duration: .2s;
}

.application-form__input::-webkit-input-placeholder {
  color: #CACACA;
}

.application-form__input::-moz-placeholder {
  color: #CACACA;
}

.application-form__input--fio {
  height: 60px;
}

.application-form__input--email {
  height: 60px;
}

.application-form__input--message {
  min-height: 150px;
  padding-top: 14px;
  margin-bottom: 32px;
  resize: none;
  line-height: 32px;
}

.application-form__button-checkbox-wrapper {
  display: flex;
}

.application-form__checkbox-container {
  display: flex;
  margin-left: 22px;
  align-items: center;
}

.application-form__input-checkbox {
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  margin: 0px;
}

.application-form__check-label {
  position: relative;
  padding-left: 18px;
  user-select: none;
  cursor: pointer;
}

.application-form__check-label::before {
  content: "";
  position: absolute;
  left: 0;
  top: 50%;
  transform: translateY(-50%);
  width: 12px;
  height: 12px;
  border: 1px solid #CACACA;
}

.application-form__check-label::after {
  content: "";
  position: absolute;
  display: none;
  top: 50%;
  left: 4.5px;
  width: 3px;
  height: 6px;
  border-right: 2px solid;
  border-bottom: 2px solid;
  border-color: #97EE3F;
  transform: translateY(-60%) rotate(45deg);
}

.application-form__input-checkbox:checked +
.application-form__check-label::after {
  content: "";
  display: block;
}

.application-form__input-checkbox:focus +
.application-form__check-label::before {
  border: 1px solid var(--primary-color);
}

.application-form__button {
  padding: 19px 52px;
  text-align: center;
  border: none;
  cursor: pointer;
  transition-property: background-color;
  transition-duration: .2s;
}

.index-footer__right {
  padding-top: 87px;
  margin-left: 20px;
  max-width: 20.5%;
  color: #CACACA;
  font-size: 16px;
  line-height: 32px;
}

/* Focus */
.mobile-menu__close-button:focus {
  outline: 2px solid var(--primary-color);
}

.mobile-menu__nav-link:focus {
  outline: 2px solid var(--primary-color);
}

.header-nav__link:focus {
  border: none;
  outline: 2px solid var(--primary-color);
}

.header__search-button:focus {
  outline: 2px solid var(--primary-color)
}

.header__search-input:focus {
  outline: none;
  border-color: var(--primary-color);
}

.header__search-submit:focus {
  outline: 2px solid var(--primary-color);
}

.header__search-close:focus {
  outline: 2px solid var(--primary-color);
}

.order__order-payment:focus {
  background-color: rgba(255, 153, 0, 0.7);
  outline: none;
}

.button--section-about:focus {
  background-color: var(--primary-color);
  outline: none;
}

.as-we-work__step-button:focus {
  outline: 2px solid var(--primary-color);
}

.as-we-work__more:focus {
  background-color: #F7B045;
  outline: none;
}

.as-we-work__offer:focus {
  background-color: #666666;
  color: #FFFFFF;
  outline: none;
  border-color: #666666;
}

.question:focus-within {
  color:var(--primary-color);
  border-color: var(--primary-color);
  outline: none;
}

.question:focus-within
.question__icon {
  background-color:var(--primary-color);
}

.question:focus-within
.question__icon::before {
  background-color:#FFFFFF;
}

.question:focus-within
.question__icon::after {
  background-color:#FFFFFF;
}

.question__heading:focus {
  outline: none;
}

.footer-nav__link:focus {
  outline: 2px solid var(--primary-color);
}

.social-link:focus {
  outline: 2px solid var(--primary-color);
}

.application-form__input:focus {
  background-color: #666666;
  outline: none;
}

.application-form__button:focus {
  background-color: #F7B045;
  outline: none;
}

/* Hover */
.burger-button:hover {
  cursor: pointer;
}

.mobile-menu__nav-link:hover {
  cursor: pointer;
  outline: none;
}

.header-nav__link:hover {
  border-bottom: 2px solid var(--primary-color);
  outline: none;
}

.header__search-button:hover {
  color: var(--primary-color);
  outline: none;
}

.mobile-menu__close-button:hover {
  cursor: pointer;
  outline: none;
}

.order__order-payment:hover {
  background-color: rgba(255, 153, 0, 0.7);
}

.button--section-about:hover {
  background-color: var(--primary-color);
}

.header__search-submit:hover {
  cursor: pointer;
}

.header__search-close:hover {
  cursor: pointer;
}

.as-we-work__step-button:hover {
  color: var(--primary-color);
  outline: none;
}

.as-we-work__more:hover {
  background-color: #F7B045;
}

.as-we-work__offer:hover {
  background-color: #666666;
  color: #FFFFFF;
  border-color: #666666;
}

.question:hover {
  color:var(--primary-color);
  border-color: var(--primary-color);
}

.question:hover
.question__icon {
  background-color:var(--primary-color);
}

.question:hover
.question__icon::before {
  background-color:#FFFFFF;
}

.question:hover
.question__icon::after {
  background-color:#FFFFFF;
}

.footer-nav__link:hover {
  color: var(--primary-color);
  outline: none;
}

.social-link:hover {
  outline: none;
}

.social-link:hover
.index-footer__social-link-color {
  fill: var(--primary-color);
}

.application-form__input:hover {
  background-color: #666666;
}

.application-form__button:hover {
  background-color: #F7B045;
}

/* Active */
.header-nav__link:active {
  border-bottom: 2px solid #E1670E;
  color: #E1670E;
  outline: none;
}

.order__order-payment:active {
  background-color: #E1670E;
}

.button--section-about:active {
  background-color: #E1670E;
  border-color: #E1670E;
}

.as-we-work__step-button:active {
  color: #E1670E;
  outline: none;
}

.as-we-work__more:active {
  background-color: #E1670E;
  border-color: #E1670E;
}

.as-we-work__offer:active {
  background-color: #000;
  border-color: #000;
}

.question:active {
  border-color: #CACACA;
  outline: none;
}

.ui-accordion-header-active
.question__icon {
  background-color: #ECECEC;
  transform: translateY(-50%) rotate(45deg);
}

.footer-nav__link:active {
  color: #E1670E;
  outline: none;
}

.social-link:active
.index-footer__social-link-color {
  fill: #E1670E;
  outline: none;
}

.application-form__button:active {
  background-color: #E1670E;
}

@media (max-width: 1256px) {
  .burger-button {
    display: block;
  }

  .header-nav--header {
    display: none;
  }

  .header__container {
    min-height: 100px;
    justify-content: space-between;
  }

  .container {
    padding-left: 50px;
    padding-right: 50px;
  }

  .header__logo {
    width: 150px;
  }

  .about__cards {
    flex-direction: column;
  }

  .about__cards-wrapper {
    width: 100%;
  }

  .about__cards-wrapper--big {
    margin-bottom: 32px;
  }

  .about__text {
    margin-bottom: 61px;
  }

  .card-big__content {
    padding-left: 5.4%;
    padding-right: 5.4%;
  }

  .about-card--bilder {
    min-height: 640px;
  }

  .card-small {
    padding-left: 34.1%;
    background-position: 10% center;
    background-size: 20.8%;
  }

  .card-small__text {
    max-width: 450px;
  }

  .as-we-work__content::after {
    background-image: url(../pictures/consultation-1024.jpg);
  }

  .index-footer-container {
    justify-content: space-between;
  }

  .index-footer__right {
    display: none;
  }

  .index-footer__left {
    margin-right: 20px;
  }

  .index-footer__center {
    margin-right: 0px;
  }

  .application-form__button {
    padding-right: 37.5px;
    padding-left: 37.5px;
  }

  .application-form__heading {
    margin-bottom: 27px;
  }
}

@media (max-width: 1024px) {
  .index-section {
    padding-top: 40px;
    padding-bottom: 40px;
  }

  .order {
    padding-top: 0px;
  }

  .questions {
    padding-bottom: 80px;
  }

  .as-we-work {
    padding-top: 42px;
  }

  .order__wrapper {
    padding: 160px 77px;
  }

  .order__background--1 {
    background-image: url(../pictures/project-solutions-back_1024.jpg);
    background-position: 0% 50%;
  }

  .order__heading {
    margin-bottom: 16px;
    font-size: 60px;
    line-height: 73px;
  }

  .order__description {
    margin-bottom: 60px;
    font-size: 20px;
    line-height: 24.38px;
  }

  .as-we-work__heading {
    margin-bottom: 50px;
  }

  .as-we-work__btn-step-list {
    margin-bottom: 52px;
  }

  .as-we-work__content {
    width: 47.29%;
  }

  .as-we-work__content::after {
    left: 111.4%;
    width: 100%;
    background-image: url(../pictures/consultation-1024.jpg);
  }

  .as-we-work__text-content {
    margin-bottom: 22px;
  }

  .questions-heading {
    margin-bottom: 34px;
  }

  .question__heading {
    font-size: 20px;
  }

  .question__heading--length-limitation1 {
    max-width: calc(639px + 80px);
  }

  .question__heading--length-limitation2 {
    max-width: calc(756px + 80px);
  }

  .index-footer__center {
    min-width: 541px;
  }
}

@media (max-width: 979px) {
  .index-footer-container {
    flex-direction: column-reverse;
  }

  .index-footer__center {
    margin-left: 0;
  }

  .index-footer__center {
    width: 541px;
    margin-bottom: 50px;
  }

  .footer-nav {
    display: none;
  }
}

@media (max-width: 768px) {
  .order__wrapper {
    padding-left: 40px;
    padding-right: 40px;
  }

  .header__container {
    min-height: 69px;
  }

  .header__container {
    padding-top: 10px;
    padding-bottom: 10px;
  }

  .mobile-menu {
    padding-top: 21px;
    min-height: 737px;
  }

  .order {
    margin-top: 69px;
  }

  .order__heading {
    margin-bottom: 16px;
    font-size: 50px;
    line-height: 61px;
  }

  .order__description {
    font-size: 18px;
    line-height: 22px;
  }

  .about-card--bilder {
    min-height: 650px;
  }

  .card-big__content {
    padding: 34px 5.9%;
  }

  .card-big__text {
    max-width: 366px;
  }

  .card-small {
    padding: 35px 46px 35px 25.1%;
    min-height: 235px;
    background-position: 7% center;
    background-size: 16.8%;
  }

  .as-we-work {
    padding-top: 36px;
  }

  .as-we-work__btn-step-list {
    max-width: 100%;
    margin-bottom: 49px;
  }

  .as-we-work__content {
    margin-right: none;
    padding-top: 322px;
    width: 100%;
  }

  .as-we-work__content::after {
    bottom: auto;
    top: 0;
    left: 0;
    width: 100%;
    height: auto;
    min-height: 284px;
    background-image: url(../pictures/consultation.jpg);
    background-position: center;
  }

  .questions {
    padding-top: 42px;
  }

  .question__heading {
    max-width: calc(570px + 80px);
  }
}

@media (max-width: 670px) {
  .index-section {
    padding-top: 30px;
    padding-bottom: 30px;
  }

  .order {
    padding-top: 0px;
  }

  .questions {
    padding-bottom: 60px;
  }

  .as-we-work {
    padding-top: 31px;
  }

  .section__heading {
    margin-bottom: 21px;
    font-size: 24px;
    line-height: 29px;
  }

  .about__heading {
    margin-bottom: 21px;
    padding-left: 0px;
  }

  .about__text {
    margin-bottom: 12px;
    font-size: 14px;
    line-height: 28px;
  }

  .about-card--bilder {
    min-height: 400px;
    background-position: top;
  }

  .card-big__content {
    flex-direction: column;
    align-items: flex-start;
    padding: 10px;
  }

  .card-big__text {
    margin-right: 0px;
    margin-bottom: 8px;
    max-width: none;
    font-size: 14px;
    font-weight: 400;
    line-height: 28px;
  }

  .button--section-about {
    padding: 12px 42px;
    border-width: 2px;
    font-size: 12px;
  }

  .button--section-about:hover {
    color: white
  }

  .card-small {
    padding: 0px;
    padding-top: 61px;
    min-height: 0;
    border: none;
    background-size: 64px 49px;
    background-position: 0 0;
  }

  .card-small__heading {
    margin-bottom: 4px;
    font-size: 18px;
    font-weight: 500;
    line-height: 22px;
  }

  .card-small__text {
    font-weight: 400;
    font-size: 14px;
    line-height: 28px;
  }

  .as-we-work__content {
    padding-top: 300px;
  }

  .section-heading {
    font-size: 24px;
    line-height: 29px;
  }

  .as-we-work__step-button {
    font-size: 14px;
    line-height: 17px;
  }

  .as-we-work__heading {
    margin-bottom: 20px;
  }

  .as-we-work__btn-step-list {
    margin-bottom: 14px;
  }

  .as-we-work__content-heading {
    margin-bottom: 6px;
    font-weight: 500;
    font-size: 18px;
    line-height: 32px;
  }

  .as-we-work__text-content {
    margin-bottom: 16px;
    font-size: 14px;
    line-height: 28px;
  }

  .as-we-work__more {
    padding: 11px 43px;
    font-weight: 700;
    font-size: 12px;
    line-height: 15px;
  }

  .button--offer {
    padding: 10px 30px;
    font-size: 12px;
    line-height: 15px;
  }

  .questions-heading {
    margin-bottom: 16px;
  }

  .question__heading {
    font-size: 14px;
    font-weight: 500;
    line-height: 24px;
  }

  .question__icon {
    width: 40px;
    height: 40px;
  }

  .index-footer__center {
    min-width: 0;
    width: 100%;
    margin-bottom: 16px;
  }

  .application-form__heading {
    font-size: 24px;
    line-height: 29.26px;
  }

  .application-form__input {
    font-size: 14px;
  }

  .application-form__button {
    width: 200px;
    margin: 0 auto;
    margin-bottom: 11px;
    padding: 13px 23px;
    font-size: 12px;
  }

  .application-form__button-checkbox-wrapper {
    flex-direction: column;
  }

  .application-form__checkbox-container {
    margin: 0 auto;
  }

  .application-form__check-label {
    padding-top: 0;
  }

  .index-footer__left {
    display: flex;
    flex-direction: column;
    align-items: center;
    min-width: 100%;
    padding-top: 16px;
    border-top: 1px solid #595959;
  }

  .index-footer__logo {
    margin-bottom: 20px;
  }

  .index-footer__social-link-group {
    min-width: 240px;
  }
}

@media (max-width: 580px) {
  .container {
    padding-left: 20px;
    padding-right: 20px;
  }
  .header__search-container {
    position: static;
  }

  .header__search-form-container {
    width: 100vw;
    min-height: 69px;
    right: 0;
    padding-right: 15px;
    padding-left: 15px;
    transform: translateY(0);
    border-radius: 0;
  }

  .header__search-form {
    margin-left: 2px;
  }

  .header__search-input {
    width: 69.3vw;
    padding-bottom: 8px;
    font-size: 16px;
  }

  .card-big {
    padding-top: 72.5%;
    background-size: contain;
    background-position: top center;
  }

  .card-big__content {
    padding: 0px;
    background: none;
    color: #000;
  }

  .button--section-about {
    color: var(--primary-color);
  }
}

@media (max-width: 430px) {
  :root {
    --swiper-pagination-bullet-size: 10px;
    --swiper-pagination-bullet-margin-bottom: 15px;
  }
  .header__search-input {
    margin-right: 0px;
  }

  .order__wrapper {
    padding: 60px 22px;
  }

  .order__content {
    text-align: center;
  }

  .order__heading {
    margin-bottom: 6px;
    font-size: 20px;
    line-height: 24px;
  }

  .order__description {
    margin-bottom: 32px;
    font-size: 12px;
    line-height: 15px;
  }

  .order__order-payment {
    min-width: 162px;
    padding: 13px 24.5px;
    font-size: 12px;
  }

  .as-we-work__content::after {
    min-height: 168.1px;
  }

  .as-we-work__content {
    padding-top: 183px;
  }

  .as-we-work__more {
    margin-right: 10px;
  }

  .index-footer {
    padding-top: 33px;
  }

  .index-footer__logo {
    max-width: 131px;
  }

  .index-footer__social-link-group {
    min-width: 153px;
  }

  .index-footer__social-link {
    width: 40px;
    height: 40px;
  }
}

@media (max-width: 320px) {
  .container {
    padding-right: 15px;
    padding-left: 15px;
  }

  .header__container {
    padding-top: 17px;
    padding-bottom: 17px;
  }

  .header__logo {
    width: 110px;
  }

  .header__search-input {
    margin-right: 0px;
  }

  .mobile-menu {
    min-width: 320px;
    min-height: 377px;
    padding: 23px 15px;
  }

  .mobile-menu__nav-item:not(:last-child) {
    margin-bottom: 32px;
  }

  .mobile-menu__nav-item {
    font-size: 16px;
    line-height: 19.5px;
  }

  .mobile-menu__close-button {
    margin-bottom: 32px;
  }

  .mobile-menu__nav-link {
    font-size: 16px;
    line-height: 19.5px;
  }

  .as-we-work__content::after {
    min-height: 160px;
  }

  .as-we-work__content {
    padding-top: 178px;
  }

  .questions {
    padding-top: 34px;
  }

  .question__heading {
    padding-right: 46px;
  }

  .question__icon {
    width: 30px;
    height: 30px;
  }

  .application-form__button {
    max-width: 180px;
  }

  .application-form__heading {
    margin-bottom: 21px;
  }

  .application-form__input {
    padding-left: 20px;
  }

  .application-form__input--message {
    margin-bottom: 25px;
  }

  .application-form__button {
    padding-top: 10.5px;
    padding-bottom: 10.5px;
  }

  .index-footer__logo {
    margin-bottom: 16px;
  }
}
