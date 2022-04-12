import React, { Component } from 'react';
import { PayrollEmployee } from './PayrollEmployee';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div className="Maindiv">
        <PayrollEmployee></PayrollEmployee>
      </div>
    );
  }
}
