import React, { Component } from 'react';
import { DatePicker, Button } from 'antd';
import 'antd/dist/antd.css';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <DatePicker />
            <br />
            <br />

            <Button type="primary">Primary Button</Button>
            <Button>Default Button</Button>
            <Button type="dashed">Dashed Button</Button>
            <br />
        </div>
    );
  }
}
