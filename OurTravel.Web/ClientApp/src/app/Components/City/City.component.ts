import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { City } from '../../Shared/Models/City';
import { RepositoryService } from '../../Shared/Services/Repository.service';

@Component({
  selector: 'app-City',
  templateUrl: './City.component.html',
  styleUrls: ['./City.component.css']
})
export class CityComponent implements OnInit {

  cityId: string = '';
  cityData: City = new City;
  constructor(private activateRoute: ActivatedRoute, public service: RepositoryService<City>) { }

  ngOnInit() {
    this.cityId = this.activateRoute.snapshot.paramMap.get('id')!;
    this.service.GetDataDetails('cities', this.cityId)
      .subscribe({
        next: resp => {
          this.cityData = resp as City
          console.log(this.cityId);
        },
        error: err => { console.log(err) }
      });

  }

}
