import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';


import { AppComponent } from './app.component';
import { FetchdataComponent } from './fetchdata/fetchdata.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { DataViewComponent } from './data-view/data-view.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';

import { CookieService } from 'angular2-cookie/services/cookies.service';
import { AuthService } from './services/auth.service';
import { LogoutComponent } from './logout/logout.component';


@NgModule({
  declarations: [
    AppComponent,
    FetchdataComponent,
    NavMenuComponent,
    HomeComponent,
    DataViewComponent,
    DashboardComponent,
    LoginComponent,
    LogoutComponent
  ],
  imports: [
      BrowserModule,
      HttpModule,
      BrowserAnimationsModule,
      RouterModule.forRoot([
          { path: '', redirectTo: 'login', pathMatch: 'full' },
          { path: 'home', component: HomeComponent, canActivate:[AuthService]},
          { path: 'data-view', component: DataViewComponent, canActivate: [AuthService] },
          { path: 'login', component: LoginComponent },
          {path:'logout', component: LogoutComponent}

          
      ])
  ],
  providers: [CookieService, AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
