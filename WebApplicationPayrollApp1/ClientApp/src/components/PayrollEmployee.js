import React, { Component } from 'react';
import axios from 'axios';

export class PayrollEmployee extends Component {
  static displayName = PayrollEmployee.name;

  // eslint-disable-next-line no-useless-constructor
  constructor (props) {
    super(props);
  }
  
  CalculateBenfitsCost () {
    let config = {
      headers: {
        'Access-Control-Allow-Origin' : '*',
        'contentType': 'application/json',
      }
    }

    let model = { 
      employee: { 
        FirstName: (document.getElementById("fname")).value, 
        LastName: (document.getElementById("lname")).value }, 
      employeeDependents: [
        {  FirstName: (document.getElementById("fname1")).value, 
           LastName: (document.getElementById("lname1")).value },
        {  FirstName: (document.getElementById("fname2")).value, 
           LastName: (document.getElementById("lname2")).value },
        {  FirstName: (document.getElementById("fname3")).value, 
            LastName: (document.getElementById("lname3")).value },
        {  FirstName: (document.getElementById("fname4")).value, 
           LastName: (document.getElementById("lname4")).value },
        {  FirstName: (document.getElementById("fname5")).value, 
           LastName: (document.getElementById("lname5")).value },
        {  FirstName: (document.getElementById("fname6")).value, 
           LastName: (document.getElementById("lname6")).value }
       ] 
    }

    axios
    .post("http://localhost:52688/Payroll/CalculateBenefitCost", model, config)
    .then(data => 
      { 
        document.getElementById("TotalBenfitsCost").innerHTML = "$" + data.data;
      })
    .catch(error => console.log(error));
  }

  render () {
    return (
      <div>
          <h1>Payroll Benfits Cost</h1>
          <hr></hr>
          <br></br>

          <h2>Employee</h2>
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname" name="fname" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname" name="lname" />
          <br></br><br></br>

          <h2>Employees Dependants</h2>
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname1" name="fname1" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname1" name="lname1" />
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname2" name="fname2" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname2" name="lname2" />
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname3" name="fname3" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname3" name="lname3" />
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname4" name="fname4" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname4" name="lname4" />
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname5" name="fname5" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname5" name="lname5" />
          <br></br>
          <label className="Generalelements"> First name: </label>
          <input type="text" id="fname6" name="fname6" />
          <label className="Generalelements"> Last name: </label>
          <input type="text" id="lname6" name="lname6" />
          <br></br><br></br>

          <input type="button" value="Calculate" onClick={this.CalculateBenfitsCost}></input>
          <br></br>

          <br></br>
          <label className="Generalelements"> Total Benfits Cost Per Pay Period: </label>
          <label id="TotalBenfitsCost" className="Generalelements">$0</label>
          <br></br><br></br>
      </div>
    );
  }
}
