import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Country } from 'src/app/Shared/Models/Country';
import { RepositoryService } from 'src/app/Shared/Services/Repository.service';




@Component({
  selector: 'app-CountryDetails',
  templateUrl: './CountryDetails.component.html',
  styleUrls: ['./CountryDetails.component.css']
})
export class CountryDetailsComponent implements OnInit {

  countryId : string = '';
  countryData: Country = new Country;
  constructor(private activateRoute: ActivatedRoute, public service: RepositoryService<Country> ) { }

  ngOnInit() {
    this.countryId = this.activateRoute.snapshot.paramMap.get('id')!;
    this.service.GetDataDetails('countries', this.countryId)
      .subscribe({
        next: resp => {
          this.countryData = resp as Country
          console.log(this.countryData)
        },
        error: err => {console.log(err)}
      });
  }

}
