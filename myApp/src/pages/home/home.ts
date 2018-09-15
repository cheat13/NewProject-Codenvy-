import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

    n : number ;
    numbers:number[];

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }
  
  getNumber() {
     this.http.get<number[]>("http://node18.codenvy.io:40364/api/Values/GetNumbers/" + this.n)
        .subscribe(data => {
            this.numbers = data;
            console.log(this.numbers);
        });
  }


}
