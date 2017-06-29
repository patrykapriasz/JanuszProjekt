import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { DataColumnsService } from '../services/data-columns.service';
import { IColumns } from '../interfaces/icolumns';
import { trigger, state, style, transition, animate, keyframes, group } from '@angular/animations';

@Component({
  selector: 'app-data-view',
  templateUrl: './data-view.component.html',
  styleUrls: ['./data-view.component.css'],
  providers: [DataColumnsService],
  animations: [
      trigger('enter', [
          state('in', style({ width: 120, transform: 'translateX(0)', opacity: 1 })),
          transition('in=>active', [
              style({ width: 10, transform: 'translateX(50px)', opacity: 0 }),
              group([
                  animate('0.3s 0.1s ease', style({ transform: 'translateX(0)', width: 120 })),
                  animate('0.3s 0.2s ease', style({opacity:0}))
              ])
          ])
      ]),

      trigger('enter1', [
          state('in', style({
              transform: 'translateX(0)'
          })),
          transition('void=>*', [
              style({
                  transform: 'translateX(150%)'
              }), animate(900)])
      ])
  ]
})
export class DataViewComponent implements OnInit {

  constructor(private _service:DataColumnsService) { }

  public columnsData: IColumns[];
  dateFilter: Date;
  dateFilter2: Date;



  getColumnsData() {
      this._service.getColumnsData().subscribe(res => this.columnsData = res);
  }

  getColumnsFilter(item: any) {
      this.dateFilter = item;
      this.dateFilter2 = null;
      this._service.getColumnsDataFilter(this.dateFilter).subscribe(res => this.columnsData = res);
  }

  getColumnsRange(item:Date, item2:Date) {
      this.checkNull(item, item2);
      this._service.getColumnsDataRange(item, item2).subscribe(res => this.columnsData = res);
  }

  checkNull(item: Date, item2: Date) {
      this.dateFilter = item;
      if (!item2) {
          this.dateFilter2 = this.dateFilter;
      } else {
          this.dateFilter2 = item2;
      }
  }

    //animations

    flip: string = 'in';

    toggleFlip() {
        this.flip = (this.flip == 'in') ? 'active' : 'in'; 
    }
  
  ngOnInit() {
      this.getColumnsData();
  }

}
