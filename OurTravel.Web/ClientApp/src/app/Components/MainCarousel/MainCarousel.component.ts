import { NgClass } from '@angular/common';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-MainCarousel',
  templateUrl: './MainCarousel.component.html',
  styleUrls: ['./MainCarousel.component.css']
})
export class MainCarouselComponent implements OnInit {

  ImageContainerStyles = { transform: `translateX(0px)` }

  constructor() {
  }

  ngOnInit() {
    
  }
  pointClicked(i: number){

    let position = i;
    let operation = position * -55;
    this.ImageContainerStyles ={transform :`translateX(${operation}%)`}

    let points = document.getElementsByClassName("points")[0];

    points.childNodes.forEach((SingPoint, i) =>{
      (<HTMLElement>points.childNodes[i]).classList.remove('active');
    });

    (<HTMLElement>points.childNodes[i]).classList.add('active');
  }
}
