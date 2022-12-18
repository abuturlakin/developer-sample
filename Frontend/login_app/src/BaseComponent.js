import React from "react";

export default class BaseComponent extends React.Component {
    constructor(props) {
        super(props);
        this.onTextBoxChange = this.onTextBoxChange.bind(this);
    }    
    
    onTextBoxChange(event) {
        const target = event.target;
        this.setState({ [target.id]: target.value })
    }
}