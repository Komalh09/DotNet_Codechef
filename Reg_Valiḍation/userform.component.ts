import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-userform',
  standalone: true,
  imports: [FormsModule, CommonModule, ReactiveFormsModule],
  templateUrl: './userform.component.html',
  styleUrls: ['./userform.component.css']
})
export class UserformComponent {
  dob: string = '';
  age: number = 0;

  calculateAge(userForm: NgForm) {
    const dobControl = userForm.controls['dob'];
    if (dobControl) {
      const birthDate = new Date(dobControl.value);
      const today = new Date();
      let age = today.getFullYear() - birthDate.getFullYear();
      const monthDifference = today.getMonth() - birthDate.getMonth();
      if (monthDifference < 0 || (monthDifference === 0 && today.getDate() < birthDate.getDate())) {
        age--;
      }
      this.age = age;
    }
  }

  onSubmit(userForm: NgForm) {
    if (userForm.valid) {
      const { firstName, userName, password, confirmPassword, mobileNo, dob } = userForm.value;

      if (password !== confirmPassword) {
        alert('Passwords do not match');
        return;
      }
      if (!/^\d{10}$/.test(mobileNo)) {
        alert('Mobile number should be 10 digits');
        return;
      }
      if (this.age > 100) {
        alert('Age should not be more than 100');
        return;
      }

      alert('Form submitted successfully');
      console.log('Form Data:', {
        firstName,
        userName,
        password,
        mobileNo,
        dob,
        age: this.age
      });
    }
  }
}
