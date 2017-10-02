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
  public lineChartData: any;
  public lineChartLabels:any;

  getDateValues() {
      this._serviceChart.getDate().subscribe(res => this.lineChartLabels = res);
  }

    getStrengthValues() {
        this._serviceChart.getStrength().subscribe(res => this.lineChartData = res);
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

  public randomize(): void {
      // Only Change 3 values

      this.barChartData = this.lineChartData;
      console.log(this.barChartData);
  }
  


}
