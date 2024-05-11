@font-face {
  font-weight: 700;
  font-style: normal;
  font-family: "Muller";
  font-display: swap;
  src:
    local("Muller"),
    url("../fonts/MullerBold.woff2") format("woff2"),
    url("../fonts/MullerBold.woff") format("woff");
}

@font-face {
  font-weight: 500;
  font-style: normal;
  font-family: "Muller";
  font-display: swap;
  src:
    local("Muller"),
    url("../fonts/MullerMedium.woff2") format("woff2"),
    url("../fonts/MullerMedium.woff") format("woff");
}

@font-face {
  font-weight: 400;
  font-style: normal;
  font-family: "Muller";
  font-display: swap;
  src:
    local("Muller"),
    url("../fonts/MullerLight.woff2") format("woff2"),
    url("../fonts/MullerLight.woff") format("woff");
}

/* Fonts */

.visually-hidden {
  position: absolute;
  clip: rect(0 0 0 0);
  width: 1px;
  height: 1px;
  margin: -1px;
}

h2 {
  font-family: "Muller";
  font-weight: 400;
  font-size: 40px;
}

.header-tel {
  font-family: "Muller";
  font-weight: 500;
}

.header {
  font-family: "Muller";
  font-weight: 400;
  font-size: 16px;
}
.header-return {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.actions-button {
  font-family: "Muller";
  font-weight: 400;
  font-size: 16px
}

.offers-card-heading {
  font-family: Muller;
  font-weight: 700;
  font-size: 40px;
}

.luxury-heading {
  font-size: 60px;
}

.offers-card-price {
  font-family: Muller;
  font-weight: 400;
  font-size: 20px;
}

.link {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.about-text {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.servises-heading-link {
  font-family: Muller;
  font-weight: 500;
  font-size: 20px;
}

.service-card-text {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.advantage {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.placement-list {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.hotel-price {
  font-family: Muller;
  font-weight: 700;
  font-size: 20px;
}

.hotel-name {
  font-family: Muller;
  font-weight: 400;
  font-size: 16px;
}

.placement-more-link {
  font-family: Muller;
  font-weight: 500;
  font-size: 20px;
}

/* Global Settings */
* {
  box-sizing: border-box;
}

p {
  margin: 0px;
}

h2 {
  margin: 0px;
}

h3 {
  margin: 0px;
}

a {
  text-decoration: none;
}

ul {
  margin: 0px;
  padding: 0px;
  list-style: none;
}

img {
  max-width: 100%;
}

.container {
  max-width: 1200px;
  margin: 0 auto;
padding: 0px 15px;
}

.arrow::after {
  position: relative;
  top: 1px;
  display: inline-block;
  content: "";
  width: 11px;
  height: 11px;
  border-top: 2px solid;
  border-right: 2px solid;
  transform: rotate(45deg)
}


/* Body */
.body-index {
  background-color: #F1F1F1;
}

/* Header */
.header {
  padding-top: 30px;
  padding-bottom: 35px;
}

.header-top {
  display: flex;
  margin-bottom: 30px;
  align-items: center;
}

.header-top-left {
  display: flex;
  align-items: center;
}

.header-tel-cont {
  display: flex;
  flex-wrap: wrap;
  max-width: 744px;
}

.header-tel {
  margin-right: 10px;
  color: #666666;
  font-size: 20px;
}

.header-return {
  margin-left: auto;
  padding-left: 28px;
  max-width: 695px;
  color: #CC9933;
  background: url(..//pictures/arrow.svg) no-repeat;
  background-position: left top;
  line-height: 16px;

}

.header-logo {
  margin-right: 40px;
}

.nav {
  display: flex;
  padding: 27px 45px;
  align-items: center;
  justify-content: space-between;
  background-color: #FFFFFF;
  border-radius: 15px;
}

.nav-list {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  min-height: 50px;
  max-width: 745px;
  padding-right: 55px;
  border-right: solid 1px #E1E1E1;
  ;
}

.nav-item:not(:last-child) {
  margin-right: 45px;
}

.nav-link {
  color: #666666;

}

.actions {
  display: flex;
  flex-wrap: wrap;
  max-width: 420px;
  margin-bottom: -10px;
  padding-left: 20px;
}

.actions-button {
  margin-bottom: 10px;
  padding: 13px 20px;
  border-radius: 10px;
  background-color: inherit;
  border: solid 1px #CC9933;
  color: #CC9933;
}

.actions-button:focus {
  outline: none;
}

.actions-button:not(:last-child) {
  margin-right: 40px;
}

/* Offers */
.offers {
  padding-top: 35px;
  padding-bottom: 2px;
}

.section-heading {
  margin-left: 40px;
  color:#333333;
}

.offers-heading {
  margin-bottom: 20px;
}

.offers-cards {
  display: flex;
  justify-content: space-between;
  margin-bottom: 10px;
}

.offers-thumbs {
  width: 50%;
}

.offer {
  padding: 40px 110px 40px 40px;
  margin-bottom: 23px;
  border-radius: 15px;
  color: white;
  background-repeat: no-repeat;
  background-size: cover;
  background-color: #b5b5b5;
  line-height: 1;
}

.offers-card-price {
  margin-top: 0px;
  margin-bottom: 47px;
  opacity: .8;
}

.link {
  color: #FFCC66;
  background: transparent;
}

.offer-maldives {
  min-height: 258px;
  background-image: url(..//pictures/maldives.jpg);
}

.offer-crete_hote_tours {
  min-height: 258px;
  margin-bottom: 23px;
  background-image: url(..//pictures/crete.jpg);
}

.offer-big {
  width: 50%;
  margin-left: 23px;
}

.offer-rooms_luxury {
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  align-items: flex-start;
  max-width: 573px;
  min-height: 540px;
  background-image: url(..//pictures/special-offer.jpg);
}

.offers-card-heading {
  max-width: 299px;
  margin: 0px;
  margin-bottom: 15px;
}

/* About */
.about {
  padding-top: 35px;
  padding-bottom: 35px;
}

.about-heading {
  margin-bottom: 11px;
}

.about-text {
  max-width: 888px;
  line-height: 32px;
}

/* Services */
.services {
  padding-top: 35px;
  padding-bottom: 12px;
}

.services-heading {
  margin-bottom: 20px;
}

.services-list {
  display: flex;
  flex-wrap: wrap;
}

.servises-heading-link {
  color: #CC9933;
}

.service-servicing {
  background: url(..//pictures/exclusive_offer.jpg) no-repeat;
  background-size: contain;
}

.service-rent {
  background: url(..//pictures/rent.jpg) no-repeat;
  background-size: contain;
}

.service-spa {
  background: url(..//pictures/sauna.jpg) no-repeat;
  background-size: contain;
}

.service-parking {
  background: url(..//pictures/cars.jpg) no-repeat;
  background-size: contain;
}

.services-card {
  min-height: 330px;
  max-width: 573px;
  padding: 190px 126px 10px 45px;
  margin-bottom: 23px;
  border-radius: 15px;
  background-color: white;
}

 .services-card:nth-child(odd) {
  margin-right: 23px;
}

.service-card-text {
  margin-top: 13px;
  line-height: 32px;
}

/* Advantages */
.advantages {
  padding-top: 35px;
  padding-bottom: 12px;
}

.advantages-heading {
  margin-bottom: 30px;
}

.advantages-list {
  display: flex;
  flex-wrap: wrap;
}

.advantages-bath {
  background: url(..//pictures/bathtub.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-hanger {
  background: url(..//pictures/hanger.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-heating {
  background: url(..//pictures/heating.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-key {
  background: url(..//pictures/hotel-key.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-parking {
  background: url(..//pictures/parking.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-reception {
  background: url(..//pictures/reception.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-security-box {
  background: url(..//pictures/security-box.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.advantages-swimming-pool {
  background: url(..//pictures/swimming-pool.svg) no-repeat;
  background-size: 65px;
  background-position: 45px 40px;
}

.back-color {
  background-color: white;
}

.advantages-card {
  max-width: 275px;
  min-height: 275px;
  padding: 116px 42px 10px 45px;
  margin-bottom: 23px;
  border-radius: 15px;
}

.advantages-card:not(:nth-child(4n)) {
  margin-right: 23px;
}

 .advantage {
  line-height: 32px;
}

/* Placement */
.placement {
  padding-top: 35px;
}

.placement-heading {
  margin-bottom: 30px;
}

.placement-list {
  display: flex;
  flex-wrap: wrap;
}

.placement-card {
  width: 32%;
  min-height: 440px;
  margin-bottom: 23px;
  border-radius: 15px;
  background-color: white;
}

.placement-card:not(:nth-child(3n)) {
 margin-right: 23px;
}

.hotel-img {
  display: inline-block;
  width: 100%;
  border-radius: 15px 15px 0px 0px;
}

.placement-wrapper {
  padding: 31px 45px 10px 45px;
}

.hotele-description-flex {
  display: flex;
}

.hotel-descripction {
  margin: 0px;
}

.placement-price-wrapper {
  max-width: 185px;
}

.text-gray {
  color: #999999;
}

.rating {
  display: flex;
  margin-left: auto;
}

.rating-star {
  width: 14px;
}

.rating-star:not(:last-child) {
  margin-right: 6px;
}

.hotel-name {
  margin-bottom: 16px;
}

.hotel-descripction {
  margin-bottom: 16px;
}

.hotel-rooms {
  padding: 13px 20px;
  border-radius: 15px;
  background-color: inherit;
  border: 1px solid #CC9933;
  border-radius: 10px;
  color: #CC9933;

}

.placement-card-more {
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  align-items: flex-start;
  padding: 40px 40px 27px 54px;
  background: url(..//pictures/more-variants.jpg) no-repeat;
  background-size: cover;
}

.placement-more-link {
  max-width: 280px;
  background-color: inherit;
  color: white;
}
