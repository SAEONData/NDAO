'use strict'

import React from 'react'
import { connect } from 'react-redux'
import HostedContentFrame from '../../Layout/HostedContentFrame.jsx'
import { ccrdSiteBaseURL } from '../../../Config/serviceURLs.cfg'

const mapStateToProps = (state, props) => {
  return {}
}

const mapDispatchToProps = (dispatch) => {
  return {
    updateNav: payload => {
      dispatch({ type: "NAV", payload })
    }
  }
}

class NCCRD extends React.Component {

  constructor(props) {
    super(props);
  }

  componentDidMount() {
    this.props.updateNav(location.hash)
  }

  render() {

    let { closeCallback, path, query } = this.props
    let url = ccrdSiteBaseURL

    if(path){
      url += path
    }

    if(query){
      url += query
    }

    return (
      <>
        <br />
        <HostedContentFrame
          title="Climate Change Responses"
          source={url}
          closeCallback={closeCallback}
          showSource={true}
         />
      </>
    )
  }
}

export default connect(mapStateToProps, mapDispatchToProps)(NCCRD)