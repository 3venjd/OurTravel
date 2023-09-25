import { Component, OnInit } from '@angular/core';
import { CountryService } from 'src/app/Shared/Services/Country/Country.service';

@Component({
  selector: 'app-Country',
  templateUrl: './Country.component.html',
  styleUrls: ['./Country.component.css']
})
export class CountryComponent implements OnInit {

  constructor(public service: CountryService) {

  }

  ngOnInit() {
    this.service.refreshList();
  }

}
