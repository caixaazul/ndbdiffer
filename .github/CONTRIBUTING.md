# Contributing

Thank you for your interest in contributing to NDbDiffer! In this document, we'll outline what you need to know about contributing and how to get started.

## Code of Conduct

Please see our [Code of Conduct](CODE_OF_CONDUCT.md).

## Contributing Code

[In Progress]

### What to work on

If you're looking for something to work on, please browse [open issues](https://github.com/caixaazul/ndbdiffer/issues). Any issue that is not already assigned is up for grabs. Before you select an enhancement to work on, see Status of Proposals below. Make sure you're working on something in the Ready For Implementation category!

Read and follow our [Pull Request template](PULL_REQUEST_TEMPLATE.md).

### Pull Request Requirements

 We use red-green-refactor test driven development. If you're planning to work on a bug fix, please be sure to create a test case in the UI tests suite (or unit tests, if you're working on Core code) that proves that the behavior is broken and then proves that the behavior was resolved after your changes. If at all possible, the test should be automated. If the test cannot be automated, then it should include manual testing instructions on screen.

## Proposals/Enhancements/Suggestions

To propose a change or new feature, open an issue using the [Feature request template](https://github.com/caixaazul/ndbdiffer/issues/new?assignees=&labels=proposal-open%2C+t%2Fenhancement+%E2%9E%95&template=feature_request.md&title=%5BEnhancement%5D+YOUR+IDEA%21). You may also use the [Spec template](https://github.com/caixaazul/ndbdiffer/issues/new?assignees=&labels=proposal-open%2C+t%2Fenhancement+%E2%9E%95&template=spec.md&title=%5BSpec%5D++) if you have an idea of what the Core should perform.

### Status of Proposals

Proposals (also called Enhancements or Suggestions) will start out in the [Enhancements project](https://github.com/caixaazul/ndbdiffer/projects/1) and will be sorted into columns based on their current status.

#### Under consideration
This issue is proposed to the community for further support or ideas. Make your votes, voice your opinions, and help develop a specification that someone can work from. A proposal in this column is likely not ready to be worked on yet.

#### Discussion Required
Similar to "Under consideration", except there are clear reasons or concerns about adding this to the platform. This is not quite a rejected state, but this issue requires a lot of problem solving before it should be worked on.

#### Needs Specification
This idea is accepted to be added to NDbDiffer. However, it can't be worked on until it has a clear specification, including Core changes, sample use cases, etc. See the [Spec template](https://github.com/caixaazul/ndbdiffer/issues/new?assignees=&labels=proposal-open%2C+t%2Fenhancement+%E2%9E%95&template=spec.md&title=%5BSpec%5D++) for the type of information that is needed.

#### Needs Design Review
The specification is written for this accepted proposal, and now we need to review it to make sure that it is easy to use, extensible, etc.

#### Ready for Implementation
Issues in this column should be ready to implement; all of the required information should be in the issue at this point. Unless the issue has an assignee already, anyone is welcome to pick something from this column!

#### In Progress
Issues that have a matching PR are automatically removed from this project entirely; however, if someone wants to claim an issue and submit a PR later, the issue should be moved to this column so someone else doesn't start working on it at the same time.

#### External
These issues won't involve code that is in the NDbDiffer repository, but for one reason or another, it is still tracked here.

#### Closed
Proposals that were closed without being implemented.

## Review Process
All pull requests need to be reviewed and tested by at least two members of the NDbDiffer team. We do our best to review pull requests in a timely manner, but please be patient! Two reviewers will be assigned and will start the review process as soon as possible. If there are any changes requested, the contributor should make them at their earliest convenience or let the reviewers know that they are unable to make further contributions. If the pull request requires only minor changes, then someone else may pick it up and finish it. We will do our best to make sure that all credit is retained for contributors.

Once a pull request has two approvals, it will receive an "approved" label. As long as no unit tests are failing, this pull request can be merged at this time.

## Merge Process
Bug fixes should be targeted at the earliest appropriate branch.
- _Master_ corresponds to a version that is not yet tagged. This is also the "nightly" branch. This is where anything that doesn't fit into the stable or prerelease branches should be targeted.

Commits will be merged up from stable to prerelease to master branches on a regular basis (typically every Monday and whenever a new release is tagged).
