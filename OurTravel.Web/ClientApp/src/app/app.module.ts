import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from '../app/Components/nav-menu/nav-menu.component';
import { HomeComponent } from '../app/Components/Home/home.component';
import { CounterComponent } from '../app/Components/counter/counter.component';
import { FetchDataComponent } from '../app/Components/fetch-data/fetch-data.component';
import { MainCarouselComponent } from './Components/MainCarousel/MainCarousel.component';
import { SliderComponent } from './Components/Slider/Slider.component';
import { CountryComponent } from './Components/Country/Country.component';
import { StateComponent } from './Components/State/State.component';
import { CityComponent } from './Components/City/City.component';
import { UserNameComponent } from './Components/UserName/UserName.component';
import { RepositoryService } from './Shared/Services/Repository.service';

import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { CountryDetailsComponent } from './Components/Country/CountryDetails/CountryDetails.component';

@NgModule({
  declarations: [	
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MainCarouselComponent,
    SliderComponent,
    CountryComponent,
    CountryDetailsComponent,
    StateComponent,
    CityComponent,
    UserNameComponent,
    
   ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'countryDetails/:id', component : CountryDetailsComponent},
      { path: 'state', component : StateComponent},
      { path: 'city', component : CityComponent}
    ]),
    CommonModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
  ],
  providers: [
    RepositoryService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
