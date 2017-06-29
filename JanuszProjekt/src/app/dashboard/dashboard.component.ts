import { Component, OnInit } from '@angular/core';
import { DashboardService } from '../services/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
  providers:[DashboardService]
})
export class DashboardComponent implements OnInit {

    private thermal: any;
    private methanol: number;
    private worker: string;
    private contact: string;
    private status: boolean;

    constructor(private _service: DashboardService) { }


    getTermal() {
        this._service.getTermalTemp().subscribe(res=>this.thermal=res);
    }

    getMethanol() {
        this._service.getMethanolStrength().subscribe(res => this.methanol = res);
    }

    ngOnInit() {
        this.getTermal();
        this.getMethanol();
  }

}
