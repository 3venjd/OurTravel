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
import { CountryService } from './Shared/Services/Country/Country.service';

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
      { path: 'state', component : StateComponent},
      { path: 'city', component : CityComponent}
    ])
  ],
  providers: [
    CountryService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
