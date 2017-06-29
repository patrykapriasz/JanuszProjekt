import { Component, OnInit } from '@angular/core';
import {LoginService} from '../services/login.service';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.css'],
  providers:[LoginService]
})
export class LogoutComponent implements OnInit {

  constructor(private service:LoginService) { }

  ngOnInit() {
      this.service.logout();
  }

}
