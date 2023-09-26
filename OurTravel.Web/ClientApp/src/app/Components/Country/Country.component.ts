import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Country } from 'src/app/Shared/Models/Country';
import { CountryService } from 'src/app/Shared/Services/Country/Country.service';

@Component({
  selector: 'app-Country',
  templateUrl: './Country.component.html',
  styleUrls: ['./Country.component.css']
})
export class CountryComponent implements OnInit {

  OnSubmit(form: NgForm) {
    this.service.postCountry()
    .subscribe({
      next: res => {
        //this.service.countryList = res as Country[];
        this.service.refreshList();
        this.service.resetForm(form);
      },
      error: err => {console.error(err)}
    })
  }

  constructor(public service: CountryService) {

  }

  ngOnInit() {
    this.service.refreshList();
  }

}
