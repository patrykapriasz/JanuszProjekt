import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';

@Injectable()
export class DataColumnsService {

  constructor(private _http:Http) { }

  private columnsUrl = '/api/Columns/ColumnsData';
  private columnsFilterUrl = '/api/Columns/ColumnsDataFilter';
  private columnsRangeUrl ='/api/Columns/ColumnsDataRange';

  getColumnsData() {
      return this._http.get(this.columnsUrl).map(this.myData);
  }

  getColumnsDataFilter(item:any) {
      let headers = new Headers({ 'Content-Type': 'application/json' });
      let options = new RequestOptions({ headers: headers });
      return this._http.post(this.columnsFilterUrl, JSON.stringify(item), options).catch(err=>Observable.empty()).map(this.myData);
  }

  getColumnsDataRange(item:Date, item2:Date) {
      let headers = new Headers({ 'Content-Type': 'application/json' });
      let options = new RequestOptions({ headers: headers });
      return this._http.post(this.columnsRangeUrl, JSON.stringify({ 'startTime': item, 'endTime': item2 }), options)
          .map(this.myData);
  }

  private myData(res: Response) {
      let body;
      if (res.text()) {
          body = res.json();
      }
      return body || {};
  }
}
