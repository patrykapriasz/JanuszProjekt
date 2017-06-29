import { Component, OnInit } from '@angular/core';
import { StatisticsService } from '../services/statistics.service';
import { Istatistics } from '../interfaces/istatistics';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css'],
  providers:[StatisticsService]
})
export class StatisticsComponent implements OnInit {

    constructor(private _service: StatisticsService) { }

    public tableStat: Istatistics[];

    private startDate: Date;
    private endDate: Date;


    getStat() {
        this._service.getStatGeneral().subscribe(res => this.tableStat = res);
    }

    checkNull(item: Date, item2: Date) {
        this.startDate = item;
        if (!item2) {
            this.endDate = this.startDate;
        } else {
            this.endDate = item2;
        }
    }

    ngOnInit() {
      this.getStat();
  }

}
