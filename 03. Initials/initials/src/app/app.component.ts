import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  _employeeName = '';
  _employeeInitials = '';

  onTextChanged(employeeName: string) {
    var nameArray = employeeName.split(' ');
    this._employeeInitials = '';
    nameArray.forEach(element => {
      this._employeeInitials+= element.charAt(0);
    });
  }
}
