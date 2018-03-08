import { Component } from '@angular/core';
// added httpService 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Example of Angular CLI with DotNet Core';
  apiValues: string[] = [];

  // dependency injection used to inject the httpService
  constructor(private _httpService: Http) { }

  // standard workflow: load the data before the view is rendered
  ngOnInit() {
      this._httpService.get('/api/values').subscribe(values => {
         this.apiValues = values.json() as string[];
      });
   }



}
