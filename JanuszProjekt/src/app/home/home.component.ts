import { Component, OnInit } from '@angular/core';
import {ChartsService} from '../services/charts.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [ChartsService]
})
export class HomeComponent implements OnInit {

  constructor(private _serviceChart:ChartsService) { }
  public lineChartData1: any;
  public lineChartLabels1:any;

  getDateValues() {
      this._serviceChart.getDate().subscribe(res => this.lineChartLabels1 = res);
  }

    getStrengthValues() {
        this._serviceChart.getStrength().subscribe(res => this.lineChartData1 = res);
        
    }
    
  ngOnInit() {
      this.getDateValues();
      this.getStrengthValues();
      
    }

    //charts

  public barChartOptions: any = {
      scaleShowVerticalLines: false,
      responsive: true
  };

  //Chart Labels
  
  public barChartType: string = 'bar';
  public barChartLegend: boolean = true;

  //Chart data
  public barChartData: any[] = [
//      { data: [66, 55, 83, 82, 56, 51, 43], label: 'Loss' },
        { data: [], label: 'Profit' }
  ];

  // Chart events
  public chartClicked(e: any): void {
      console.log(e);
  }

  // Chart events
  public chartHovered(e: any): void {
      console.log(e);
  }

//  public randomize(): void {
//      // Only Change 3 values
//      this.barChartData = this.lineChartData;
//      console.log(this.barChartData);
//  }



    //line

  public lineChartData: Array<any> = [
      { data: [], label: 'Stężenie w ciągu dnia' }

  ];
  public lineChartLabels: Array<any> = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];
  public lineChartOptions: any = {
      responsive: true
  };
  public lineChartColors: Array<any> = [
      { // grey
          backgroundColor: 'rgba(148,159,177,0.2)',
          borderColor: 'rgba(148,159,177,1)',
          pointBackgroundColor: 'rgba(148,159,177,1)',
          pointBorderColor: '#fff',
          pointHoverBackgroundColor: '#fff',
          pointHoverBorderColor: 'rgba(148,159,177,0.8)'
      },
      { // dark grey
          backgroundColor: 'rgba(77,83,96,0.2)',
          borderColor: 'rgba(77,83,96,1)',
          pointBackgroundColor: 'rgba(77,83,96,1)',
          pointBorderColor: '#fff',
          pointHoverBackgroundColor: '#fff',
          pointHoverBorderColor: 'rgba(77,83,96,1)'
      },
      { // grey
          backgroundColor: 'rgba(148,159,177,0.2)',
          borderColor: 'rgba(148,159,177,1)',
          pointBackgroundColor: 'rgba(148,159,177,1)',
          pointBorderColor: '#fff',
          pointHoverBackgroundColor: '#fff',
          pointHoverBorderColor: 'rgba(148,159,177,0.8)'
      }
  ];
  public lineChartLegend: boolean = true;
  public lineChartType: string = 'line';

  public randomize() {

      this.lineChartData = this.lineChartData1;
  }
  


}
