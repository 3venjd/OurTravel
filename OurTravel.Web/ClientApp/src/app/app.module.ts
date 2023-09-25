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

@NgModule({
  declarations: [	
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    MainCarouselComponent,
    SliderComponent
   ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
