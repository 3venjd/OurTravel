import { Component, Input, OnInit } from '@angular/core';
import { Places } from '../../Shared/Models/Places';

@Component({
  selector: 'app-Slider',
  templateUrl: './Slider.component.html',
  styleUrls: ['./Slider.component.css']
})
export class SliderComponent implements OnInit {

  //@Input() InterestPlace: Places;

  slideIndex: number = 1;

  plusSlides(n: number) {
    this.showSlides(this.slideIndex += n);
  }

  /*
  currentSlide(n: number): void {
    this.showSlides(this.slideIndex = n);
  }
  */
  showSlides(n: number) {
    let slides: HTMLCollectionOf<Element> = document.getElementsByClassName("mySlides");
    //let dots: HTMLCollectionOf<Element> = document.getElementsByClassName("demo");
    //let captionText: HTMLElement | null = document.getElementById("caption");

    if (n > slides.length) { this.slideIndex = 1 }
    if (n < 1) { this.slideIndex = slides.length }

    for (let i = 0; i < slides.length; i++) {
      (slides[i] as HTMLElement).style.display = "none";
    }

    /*
    for (let i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
    }
    */
    (slides[this.slideIndex - 1] as HTMLElement).style.display = "block";
    //dots[this.slideIndex - 1].className += " active";

    /*
    if (captionText && 'alt' in dots[this.slideIndex - 1]) {
      captionText.innerHTML = (dots[this.slideIndex - 1] as HTMLImageElement).alt;
    }
    */
  }


  constructor() { }

  ngOnInit() {

    this.showSlides(1);
  }



}
