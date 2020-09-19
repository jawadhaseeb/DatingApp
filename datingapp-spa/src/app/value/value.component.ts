import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.scss']
})

export class ValueComponent implements OnInit {
  values: any;

  constructor(private Http: HttpClient) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getValues();
  }
  // tslint:disable-next-line: typedef
  getValues(){
    this.Http.get('http://localhost:5000/api/values').subscribe(Response => {
      this.values = Response;
    }, error => {
      console.log(error);
    });
  }


}
